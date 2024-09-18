import { StatusBar } from 'expo-status-bar';
import { useState } from 'react';
import { StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';
import Calculadora from './src/model/Calculadora';

export default function App() {
   
  const [gasolina, setGasolina] = useState(0);
  const [alcool, setAlcool] = useState(0);

  const resultado = () => {
    let resul = new Calculadora(gasolina, alcool)

    alert("O combustível mais vantajoso é: " +resul.vantajoso()+
    "\nPreço: " +resul.preco().toFixed(2))
  }

  return (
    <View style={styles.container}>
      <Text style={styles.titulo}>COMPARATIVO DE COMBUSTÍVEL</Text> 

      <View style={styles.body}>

        <Text style={styles.texto}>Gasolina</Text>
        <TextInput style={styles.campo}
        value={gasolina}
        onChangeText={ (t)=>{ setGasolina( parseFloat(t) )} }
        keyboardType='number-pad'
        placeholder='Informe o preço da Gasolina'
        />

        <Text style ={styles.texto}>Álcool</Text>
        <TextInput style ={styles.campo} 
        value={alcool}
        onChangeText={ (t)=>{ setAlcool( parseFloat(t) )} }
        keyboardType='number-pad'
        placeholder='Informe o preço do Álcool'
        />

      </View>

      <TouchableOpacity onPress={resultado} style ={styles.btn}>
        <Text>Calcular</Text>
      </TouchableOpacity>
    </View>
  );
}

const styles = StyleSheet.create({
  btn: {
    padding: 25,
    fontSize: 32,
    backgroundColor: '#BFBFBF',
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
    backgroundColor: '#0A3A40',
    marginBottom: 10,
    width: '90%',
  },
  container: {                                         
    flex: 1,
    backgroundColor: '#042326', 
    alignItems: 'center',
    justifyContent: 'center',
  },
  texto: {
    fontSize: 20,
    paddingTop: 20,
    color: "#fff",
    textAlign: 'center',
    alignItems: 'center',
    justifyContent: 'center',
  },
  campo: {
    backgroundColor: '#fff',
    fontSize: 20,
    padding: 5,
    margin: 15,
    width: '90%',
    borderRadius: 5,
    textAlign: 'center',
  },
  titulo: {
    fontSize: 25,
    fontWeight: 'bold',
    padding: 25,
    color: "#fff",
    marginTop: 10,
    textAlign: 'center',
  }
});

