using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyContacts
{
	public static class SimpsonFactory
	{
		public static IList<Person> Characters { get; private set; }

		static SimpsonFactory()
		{
			Characters = new ObservableCollection<Person> {
				new Person { 
					Name = "Notificações de conta do instrutor", 					
					Email = "Os instrutores podem selecionar quais notificações desejam receber da Udemy na página Notificações. Se você também estiver inscrito nos cursos da Udemy como um aluno, é possível selecionar se deseja receber as notificações desses cursos.", 					
				},

                new Person {
                    Name = "Mesclar contas",
                    Email = "Se você criou acidentalmente duas contas da Udemy, podemos mesclá-las para você. No processo, seu andamento no curso e seu histórico de compra serão transferidos. Observe que as mensagens privadas e marcadores não serão transferidos. Certifique-se de salvar qualquer informação importante que você deseja manter antes de prosseguir com o processo",
                },

                new Person {
                    Name = "Organize seus cursos da Udemy usando acervos",
                    Email = "Ao usar o recurso Acervos,será possível organizar cursos em acervos com base na categoria, nos projetos e nas metas de aprendizado que você criar. Além disso, o recurso Acervos irá ajudá-lo a planejar seu aprendizado organizando cursos que você deseja fazer ao mesmo tempo.Por exemplo, se estiver inscrito em diversos cursos relacionados a desenvolvimento web, você poderá criar um acervo com o título “Desenvolvimento na Web” e atribuir cursos a esse acervo. Ou, se estiver fazendo diversos cursos destinados a ajudá-lo a abrir seu primeiro negócio, você poderá criar um acervo com o título “Meus negócios”.",
                },

                new Person {
                    Name = "Minha conta foi comprometida?",
                    Email = "Sabemos o quão estarrecedor é achar que sua conta pode ter sido acessada sem sua autorização. Mas, antes de entrar em pânico e concluir que sua conta foi comprometida, considere se pode haver uma explicação razoável para a atividade que você descobriu. Aqui estão algumas explicações comuns para atividades que podem ser confundidas com uma violação de segurança.",
                },

                new Person {
                    Name = "Como proteger sua conta",
                    Email = "A Udemy implementa protocolos de segurança para proteger sua conta, mas há muitas maneiras de você mesmo fazer isso e reduzir a probabilidade de deixá-la vulnerável. Escolha uma senha forte",
                },
            };
		}
	}
}

