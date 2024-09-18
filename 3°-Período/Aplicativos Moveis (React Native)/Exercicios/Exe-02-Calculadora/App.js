import { StatusBar } from 'expo-status-bar';
import { useState } from 'react';
import { StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';


export default function App() {

  //let v1 = 0;
  //let v2 = 5;
  const [v1, setV1] = useState(0);
  const [v2, setV2] = useState(5);
  const [resultado, setResultado] = useState(0);

  const calcular = () =>{
    //setV1 (v1 + 1);
    //setV2 (v2 + 1);
    //v2 = v2 + 1;
    setResultado(v1 + v2)
    console.log("OK ", v1, v2, resultado);
  }

  return (
    <View style={styles.container}>
      <Text style={styles.titulo}>Calculadora</Text>

      <View style={styles.body}>

        <Text style ={styles.texto}>Valor 1</Text>
        <TextInput style ={styles.campo} 
        value={v1}
        onChangeText={ (t)=>{ setV1( parseInt(t) )} }
        keyboardType='number-pad'
        placeholder='informe o valor 1'
        />

        <Text style ={styles.texto}>Valor 2</Text>
        <TextInput style ={styles.campo} 
        value={v2}
        onChangeText={ (t)=>{ setV2( parseInt(t) )} }
        keyboardType='number-pad'
        placeholder='informe o valor 2'
        />

      </View>

      {
        resultado !=0 &&
        (<Text style ={styles.res}>O resultado é {resultado}</Text>)
      }

      <TouchableOpacity onPress={calcular} style ={styles.btn}>
        <Text>Calcular</Text>
      </TouchableOpacity>
    </View>
  );
}

const styles = StyleSheet.create({
  btn: {
    padding: 25,
    fontSize: 32,
    backgroundColor: '#ccc',
    borderRadius: 15,
    marginBottom: 10,
    width: '98%',
    textAlign: 'center',
    alignItems: 'center',
    justifyContent: 'center',
  },
  body: {
    flexGrow: 1,
    flex: 1,
    //backgroundColor: '#ff0',
    marginBottom: 10,
    width: '90%',
  },
  container: {                                         
    flex: 1,
    backgroundColor: '#AA9',
    alignItems: 'center',
    justifyContent: 'center',
  },
  texto: {
    fontSize: 20,
    paddingBottom: 10,
    paddingTop: 10,
  },
  campo: {
    backgroundColor: '#fff',
    fontSize: 22,
    padding: 5,
    width: '100%',
    borderRadius: 5,
  },
  res: {
    fontSize: 32,
    width: '98%',
    textAlign: 'center',
  },
  titulo: {
    fontSize: 48,
    fontWeight: 'bold',
    padding: 25,

  }
});
