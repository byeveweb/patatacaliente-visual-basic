Module Module1

    Dim pregunta(5) As String
    Dim respuesta(5) As Integer
    Dim random As Random
    Dim num As Integer

    Function PreguntaAlUsuario() As String

        'Generar preguntas que le muestra al Usuari
        'los guardo de esta manera,Pregunta: ¿En que año descubrió Cristóbal Colon América? Respuesta: 1492
        pregunta(0) = " ¿En que año se inauguró el Metro de Madrid?"
        respuesta(0) = 1919
        pregunta(1) = " ¿En que año comenzó la guerra civil Española?"
        respuesta(1) = 1936
        pregunta(2) = " ¿En que año descubrió Colón las Américas?"
        respuesta(2) = 1492
        pregunta(3) = " ¿En que año terminó la segunda guerra mundial?."
        respuesta(3) = 1945
        pregunta(4) = " ¿En que año ganó la copa mundial de futbol España?."
        respuesta(4) = 2010
        pregunta(5) = " ¿En que año se jugó el primer mundial de fútbol?."
        respuesta(5) = 1928

        'le colocamos el random para generar nuestras preguntas
        Dim random As New Random()
        num = random.Next(5)
        'aqui nuestra pregunta que se ha generado para nuestro usuario.
        Console.WriteLine("" & pregunta(num))
        Console.WriteLine("")
        'return no dice la pregunta seleccionada
        Return pregunta(num)

    End Function

    Sub compruebaRespuesta(ByVal fechaUsuario As Integer, ByVal respuesta As Integer)

        ' comprobamos la fecha del usuario con la fecha respueta de la pregunta
        If (fechaUsuario = respuesta) Then
            Console.WriteLine("")
            Console.Out.Write(" Correcto la fecha es " & fechaUsuario & "")
        ElseIf (fechaUsuario <= respuesta) Then
            Console.WriteLine("")
            Console.Write(" Es mayor que " & fechaUsuario & "")
        Else
            Console.WriteLine("")
            Console.Write(" Es menor que " & fechaUsuario & "")
        End If
        Console.WriteLine("")

    End Sub

    Function acertado(ByVal fechaUsuario) As Boolean

        If (fechaUsuario = respuesta(num)) Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub Main()

        Dim cadenaPregunta As String
        Dim respuestas As Boolean
        Dim NumeroIntentos As Integer = 0
        'Ponemos la cabecera "pregunta seleccionada y algunos saltos"

        Console.WriteLine(" Pregunta seleccionada")
        Console.WriteLine(" |=====================|")
        Console.WriteLine("")
        cadenaPregunta = PreguntaAlUsuario()

        ' Do nos delvueve siempre una pregunta "dime una fecha" hasta 10 intentos
        Do
            NumeroIntentos = NumeroIntentos + 1
            Console.WriteLine("")
            Console.Out.WriteLine(" ¿Dime una fecha?:")
            Dim fechaUsuario As Integer = Console.In.ReadLine()
            Console.WriteLine(" " & NumeroIntentos & "º" & " Intento")
            Console.WriteLine("    =======")

            'Recojo la fecha que me diga y compruebo si es mayor o menor.
            If (fechaUsuario >= 1900) And (fechaUsuario <= 2010) Then
                'ponemos si es mayor ó menor de la fecha introducida
                compruebaRespuesta(fechaUsuario, respuesta(num))
                'comprobamos que hemos acertado
                respuestas = acertado(fechaUsuario)
            Else
                Console.Out.WriteLine(" Fecha incorrecta")
                Console.WriteLine("")
            End If
            'Fin Cambio 'Compruebo que como máximo tenga 10 intentos y si no explotará lapatata
        Loop While respuestas = False And NumeroIntentos < 10

        Console.WriteLine("Su patata explotó")
        'aqui tenemos la pregunta acertada

        If respuestas Then
            Console.WriteLine("")
            Console.Out.WriteLine(" ¡¡ Enhorabuena ha acertado la fecha  ------ Intentos " & NumeroIntentos & "")
            Console.In.Read()
        End If

        Console.ReadLine()

    End Sub
End Module
