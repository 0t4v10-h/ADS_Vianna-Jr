import { children } from "react"
import { Keyboard, View, StyleSheet, Text, TextInput } from "react-native"

export default Campo = ({children, Keyboard, mensagem}) => {

    return (
        <View style={styles.container}> 
            <Text style={styles.texto}>{children}</Text>
            {/*<Titulo tamanho="pequeno">{children}</Titulo>*/}
            <TextInput style={styles.campo} 
            keyboardType={Keyboard}
            placeholder={mensagem}
            />
        </View>
    )
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        //backgroundColor: "#ddd",
        alignItens: "flex-start",
        justifyContent: "flex-start",
        padding: 15,
        width: "98%",
    },
    campo: {
        fontSize: 22,
        padding: 5,
        backgroundColor: "#fff",
        width: "98%",
        borderColor: "#000",
        borderWidth: 1,
    },
    texto: {
        fontSize: 20,
    }
})