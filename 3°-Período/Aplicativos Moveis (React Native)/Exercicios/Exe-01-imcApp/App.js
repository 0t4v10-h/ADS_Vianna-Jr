import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';
import Titulo from './src/components/base/Titulo/Titulo';
import Campo from './src/components/base/Campo/Campo';

export default function App() {
  return (
    <View style={styles.container}>
      
      <Titulo tamanho="grande" corFundo="#bbb"> 
        IMC 
      </Titulo>
      <Titulo tamanho="medio" corFundo="#ddd">
        o seu App
      </Titulo>
      {/*<Titulo tamanho="pequeno">
        blá
      </Titulo>*/}

      <View style={styles.body}>
      
        <Campo mensagem="informe o nome" >
          <Titulo tamanho="medio">Nome</Titulo>
        </Campo>
        <Campo keyboard="numeric" >Peso</Campo>
        <Campo keyboard="numeric" >Altura</Campo>

      </View>

      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'flex-start',
  },
  body: {
    backgroundColor: "yellow",
    flexGrow: 1,
    width: "99%",
    flex: 1,
    alignItems: "center",
    justifyContent: "flex-start",
  },
});
