using System;
namespace CalculadoraSigno
{
    public class Interpretersign
    {
        private Signo[] sign = new Signo[12];


        public Interpretersign()
        {
            sign[0] = new Signo { DayBegin = 20, monthBegin = 1, DayEnd = 18, monthEnd = 2, name = "Aquário", characteristics = "Aquário nos ensina a amizade, a fraternidade, a originalidade, a inovação, o respeito às diferenças, o amor incondicional ao ser humano e à natureza. Liberdade é a palavra de Aquário." };
            sign[1] = new Signo { DayBegin = 19, monthBegin= 2,  DayEnd = 20, monthEnd = 3, name= "Peixes",   characteristics = "Peixes nos ensina a fé, a conexão com uma dimensão superior, a simplicidade, o desprendimento, a entrega à vida. Aceitação é a palavra de Peixes." };
            sign[2] = new Signo { DayBegin = 21, monthBegin = 3, DayEnd = 19, monthEnd = 4, name = "Áries",   characteristics = "Áries nos ensina a coragem, a liderança, o impulso, a motivação para iniciar projetos e seguir em frente, mesmo com obstáculos. Superação é a palavra de Áries." };
            sign[3] = new Signo { DayBegin = 20, monthBegin = 4, DayEnd = 20, monthEnd = 5, name = "Touro",   characteristics = "Touro nos ensina o cuidado, o carinho, a paciência para observar, ver crescer, acompanhar o próprio processo de desenvolvimento e o crescimento de outros. Persistência é a palavra de Touro." };
            sign[4] = new Signo { DayBegin = 21, monthBegin = 5, DayEnd = 21, monthEnd = 6, name = "Gêmeos",  characteristics = "Gêmeos nos ensina a comunicação, a boa palavra, a gentileza, a diplomacia para fazer contatos, transmitir informações e trocar opiniões com as pessoas. Conexão é a palavra de Gêmeos." };
            sign[5] = new Signo { DayBegin = 22, monthBegin = 6, DayEnd = 22, monthEnd = 7, name = "Câncer",  characteristics = "Câncer nos ensina o amor, a intimidade, a proteção, o aconchego e o suporte emocional para nos sentirmos queridos e seguros, participando de uma família. Pertencer é a palavra de Câncer." };
            sign[6] = new Signo { DayBegin = 23, monthBegin = 7, DayEnd = 22, monthEnd = 8, name = "Leão",    characteristics = "Leão nos ensina a criatividade, a alegria, a espontaneidade, a vaidade, a autoestima para seguirmos agindo corretamente e nos orgulhando de nós mesmos. Nobreza é a palavra de Leão." };
            sign[7] = new Signo { DayBegin = 23, monthBegin = 8, DayEnd = 22, monthEnd = 9, name = "Virgem",  characteristics = "Virgem nos ensina a produtividade, o amor ao trabalho, o desejo de ser útil, de servir, de ajudar a nós mesmos e às outras pessoas. Eficiência é a palavra de Virgem." };
            sign[8] = new Signo { DayBegin = 23, monthBegin = 9, DayEnd = 22, monthEnd = 10,name = "Libra",   characteristics = "Libra nos ensina o compromisso, o laço, o engajamento com os outros, a sofisticação, o amor às artes e a delicadeza que encanta e cativa as pessoas ao redor. Charme é a palavra de Libra." };
            sign[9] = new Signo { DayBegin = 23, monthBegin = 10,DayEnd = 21, monthEnd = 11,name = "Escorpião",characteristics = "Escorpião nos ensina o silêncio, a profundidade, o mistério, as emoções, a possibilidade de nos despojar e nos transformar em pessoas melhores. Transcendência é a palavra de Escorpião." };
            sign[10]= new Signo { DayBegin = 22, monthBegin = 11,DayEnd = 21, monthEnd = 12,name = "Sagitário",characteristics = "Sagitário nos ensina a esperança, a fé no futuro, a energia positiva, o interesse em ir muito mais longe para descobrir que o mundo é maior. Expansão a palavra de Sagitário." };
            sign[11]= new Signo { DayBegin = 22, monthBegin = 12,DayEnd = 19, monthEnd = 1, name = "Capricórnio",characteristics = "Capricórnio nos ensina a responsabilidade, a disciplina, a ética, a sabedoria obtida pela idade, o respeito aos mais velhos, a força de vontade. Consciência é a palavra de Capricórnio." };


        }

        public Signo Interpreter(byte day,byte month)
       {

            Signo signs = null;

            for (int i = 0; i < sign.Length; i++ )
            {
                if((day >= sign[i].DayBegin && month == sign[i].monthBegin) || (day <= sign[i].DayEnd && month == sign[i].monthEnd))
                {
                    signs = sign[i];
                }
            }  
            return signs;
        }
    }
}
