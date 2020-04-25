using MySql.Data.MySqlClient;
using proyectoSimulacionV._1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSimulacionV._1
{
    
    class LogicaSimulacion
    {
        string[] nombresAleatorios = new string[] 
        {
            "Juan José Moreira Ortuño",
            "Juan Carlos Rivero Latorre",
            "Manuela Pérez Esteban",
            "Rafael Tirado Sánchez",
            "Carmen Martínez Carrasco",
            "Francisco Franco Fernández",
            "Mario Muñoz Castro",
            "Eduardo Rodríguez Quintana",
            "Elena Santiago Martínez",
            "Miguel Muñoz Zúñiga",
            "Manuel Benítez Casals",
            "Manuel Bautista González",
            "Javier Piñeiro Martínez",
            "Ángel Álvarez Pérez",
            "María González Sancho",
            "Manuel Mora Martin",
            "Mercedes Gómez Alcázar",
            "María Teresa Canal Sánchez",
            "Alicia González Blanco",
            "Ángel Bello Rivera",
            "Irene Pérez Muñoz",
            "Bartolomé Martin García",
            "María Carmen Piñeiro Gómez",
            "Ángela Jorda Álvarez",
            "Francisco Javier Lobato Vaquero",
            "Juan López Sánchez",
            "María Carmen Muñoz Valero",
            "Ricardo Cordero Rodríguez",
            "Óscar García Martínez",
            "Pablo Quevedo Hernández",
            "Fernando Aguirre González",
            "Julia Sabaté Pizarro",
            "Mohamed Hernández Zafra",
            "Mónica Martin Romero",
            "Carmen Valdivieso Oller",
            "Mireia Sosa González",
            "Carmen López Rosa",
            "Montserrat Álvarez Ilie",
            "Julián Fernández Ramos",
            "Concepción Ruiz Sampedro",
            "Francisco Fernández Martínez",
            "Enrique Díaz Ferre",
            "Laia García Jiménez",
            "Yolanda Castillo Hermoso",
            "Lucia Puerta Mercado",
            "Daniel Martínez Casado",
            "María José García Ortega",
            "Antonio Peiro Díaz",
            "Juan José Márquez Juan",
            "Sergio Martínez Domingo",
            "Francisco Castillo Sola",
            "Andrés Rojas Gutiérrez",
            "Josefa Martínez Torres",
            "Javier Egea Gonzalo",
            "José María Bas Campos",
            "Ramón Camacho Iñigo",
            "María Rosario Aguilar Climent",
            "Pilar Gómez Hernández",
            "Montserrat Perea Martínez",
            "Antonio Fernández Ortega",
            "Francisco José Navarro Adán",
            "Juan José Gregorio Blázquez",
            "Sonia Rodríguez Moreno",
            "María Josefa Rey Pérez",
            "Elena Mayoral Morales",
            "María Dolores Rubio Melgar",
            "María Ángeles Calle Merino",
            "María Pilar Muñoz Roig",
            "Josep García Carrillo",
            "Francisca Bustos Pina",
            "Julia Morales Guerrero",
            "Manuel Jiménez Galdón",
            "Ramón Cabrera Miguélez",
            "María Carmen García Ventura",
            "Isabel Esteban Salguero",
            "María Teresa Roldan Álvarez",
            "Sonia Fernández Fernández",
            "María Pilar Díaz Balde",
            "Miguel Gallardo Fernández",
            "María Rosario Guillen Álvarez",
            "Fernando Oliver Iglesias",
            "José Antonio Cuevas Padilla",
            "Rosario Sánchez Rodríguez",
            "Sonia Infantes Del Rio",
            "Nuria Aranda Solís",
            "Juan Manuel González Casillas",
            "María Pilar Ríos Barrios",
            "Enrique Pereira Collado",
            "Ramón Checa Dos Santos",
            "Josep Cano Sánchez",
            "Francisco Domínguez Martínez",
            "Rosa María Rodríguez Fernández",
            "Sergio Gordo Rodríguez",
            "Francisco Javier Pérez Parada",
            "Pedro García Gascón",
            "Francisca Jiménez Molina",
            "María José Miranda Prieto",
            "Dolores Águila García",
            "Carmen Muñoz Rico",
            "Juan Carlos Gómez Plaza",
            "Antonio Rodríguez Fernández",
            "Xabier Otero Pérez",
            "Ramón Luengo Lorca",
            "Marta García Hermoso",
            "David Navarrete Aparicio",
            "Miguel Ángel Expósito Casado",
            "Patricia Martin Calvo",
            "Gorka Sabater Pérez",
            "Sergio Hidalgo Fernández",
            "Miguel Ángel Aguilera Bernal",
            "José Antonio García Alba",
            "Juan Antonio Escudero Camacho",
            "Pilar Camacho Marín",
            "Joaquín Arévalo Baena",
            "María Mar Tur Mateu",
            "Rubén Hernández Lorente",
            "Francisco García Prieto",
            "Pedro Duran Lorenzo",
            "Juan Castillo Rodríguez",
            "Lucia Mejía López",
            "Francisca García Ruiz",
            "Juan Barbera Martínez",
            "Alba Girón Redondo",
            "Paula Moreno Alcaraz",
            "Ramona García Ordoñez",
            "María Nieves Jiménez Falcón",
            "Sergio Llamas Barrionuevo",
            "Francisco Javier López García",
            "Miguel Ángel Sánchez Mateu",
            "Dolores Gutiérrez Ruiz",
            "Pablo Hernández Naranjo",
            "Ángel Rubia Duran",
            "Dolores López López",
            "Jesús Moreno Taylor",
            "Manuel Garrido Rubio",
            "Pablo García Navarro",
            "José Manuel Pérez Jiménez",
            "Luis León Antón",
            "Ramón Quevedo Del Rio",
            "Josefa Vázquez Prieto",
            "María Mohamed Nieto",
            "Inmaculada Patón Garmendia",
            "Juan Carlos Cañellas Granell",
            "José Ventura Campos",
            "Francisca De las Heras García",
            "María Hernández Miguel",
            "Miguel Villena López",
            "María Echeverría Díaz",
            "José María Martínez Fuentes",
            "María Josefa Giménez Martínez",
            "María Ángeles López Vázquez",
            "Santiago Ibáñez Soler",
            "Esther Jáuregui Manchón",
            "María Teresa García Fernández",
            "José Manuel Luengo Pérez",
            "Ana Arana Aguilar",
            "Miguel García Pérez",
            "Vicente Castro Zhu",
            "María José De la Cruz Sánchez",
            "Daniel Romero Cruz",
            "Eduardo Singh López",
            "José Luis García Garzón",
            "Juan Antonio Rodríguez León",
            "Sergio Fernández Sánchez",
            "José Antonio Lechuga Rueda",
            "Miguel Herrero De los Santos",
            "Carmen Díaz Mestre",
            "María Linares Infante",
            "Magdalena Narváez Lillo",
            "Ángel Yáñez González",
            "Isabel Navarro Hernández",
            "José Pérez Oliva",
            "Lucia García García",
            "Carlos Ruiz López",
            "Alberto Hernández Rodríguez",
            "Juana Antequera Sacristán",
            "Javier Valverde Rubio",
            "Francisco José Sánchez Moreno",
            "Álvaro Sánchez Rodríguez",
            "María Dolores Sánchez Pérez",
            "Marc Herranz Sánchez",
            "Miguel Ángel Trigo Aguilar",
            "José García Rosales",
            "María Alfonso Pérez",
            "Javier López Palma",
            "Juan José Benítez Guirado",
            "Amparo Redondo Pérez",
            "Lucia Cubillo Martin",
            "José Ignacio López Díaz",
            "Pilar Sánchez Ortiz",
            "Sebastián Rosillo Chamorro",
            "José Luis Martin Redondo",
            "Juana González Pérez",
            "Josefa Rodríguez García",
            "Andrés Navas De la Calle",
            "Manuel Galarza Armero",
            "Francisco Javier Ricart Navarro",
            "José María Castro Pérez",
            "María Ayala Sales",
            "José Leal Espinosa",
            "María Carmen Rosa Avilés",
            "Gerard García Jiménez",
            "Javier Castro Parrilla",
            "José Manuel Gil Jiménez",
            "Jesús Valdivia Reyes",
            "Paula Blanco Pino",
            "María Luisa Del Castillo Benítez",
            "Concepción Soto Camacho",
            "Daniel García Ocaña",
            "Pablo Martin González",
            "Rocío Albert Mena",
            "Rosario López Andrés",
            "Isabel López Mulet",
            "Marta Gil Vico",
            "María Carmen Domínguez Seijas",
            "Miguel Ángel Soler Pérez",
            "Carmen Rodríguez Martos",
            "María Luisa Crespo Abascal",
            "Antonio Sánchez Martínez",
            "Paula Villegas Muñoz",
            "Luis Fernández Fernández",
            "Francisca Rey Cánovas",
            "María Isabel Pintado Ruiz",
            "Francisco Pons Morales",
            "Beatriz Pérez Fernández",
            "Pilar Navarrete Casado",
            "Isabel Chaparro Martin",
            "Antonio Yanes Pons",
            "Eduardo Bilbao Beltrán",
            "Manuel Julia Soler",
            "José Domínguez Calatayud",
            "Mikel García Malló",
            "Pedro Castillo Ramos",
            "Jesús Trinidad Galán",
            "Manuel Sánchez Carrillo",
            "Josefa Calleja Márquez",
            "María Girona Agüera",
            "Francisco Sánchez Vadillo",
            "Teresa Gracia Rey",
            "Cristina Núñez Fraile",
            "María Carmen Mena Soler",
            "Francisca Gómez Toro",
            "Enrique Romero Torres",
            "Gabriel Rojo Pombo",
            "Ana Tolosa Fernández",
            "Ginés Sánchez Valle",
            "Alfonso Gómez García",
            "María José Herrero Llopis",
            "Daniel Rodríguez Hernández",
            "Fernando Mateo Fernández",
            "Natalia Martin Fernández",
            "Concepción Rodríguez Álvarez",
            "Carmen Marcos Cazorla",
            "Mohamed Ferrer Fernández",
            "Francisca Rodríguez Díaz",
            "José Manuel Ramírez Pérez",
            "Antonio Robledo Fernández",
            "Emilio Sánchez Gutiérrez",
            "Elena Acosta Alonso",
            "María Jesús Jiménez Duran",
            "Miguel Ángel Parrado Páez",
            "Pilar Jiménez Guzmán",
            "María Luisa López Simón",
            "Josefa Castellanos Sánchez",
            "Daniel García Agudo",
            "Ángela Georgiev Hernández",
            "María Carmen Del Castillo Narváez",
            "José María López Álvarez",
            "José Antonio Lujan Leyva",
            "María Carmen Diez Fernández",
            "Juana Rodríguez Torres",
            "Laura Gracia Esteban",
            "Francisco Hernández Rodríguez",
            "Antonia Roca León",
            "Miguel Ángel López Herráez",
            "Jesús Moreno Cadenas",
            "Andrés Barrena García",
            "Paula Calderón Toro",
            "José Manuel Martínez Silva",
            "Jaime Torras Cuenca",
            "Miguel Ángel Maldonado Román",
            "María González Martínez",
            "Iratxe Chen Sánchez",
            "María Luisa Chacón Rodrigo",
            "Oriol Bravo Morales",
            "María Mercedes Muñoz Jaramillo",
            "Juan Carlos Pérez Fontán",
            "Josep Val Arenas",
            "Roberto Martin García",
            "María Jesús Martínez Pérez",
            "María Pinilla Beltrán",
            "Manuel Maya López",
            "María Dolores Escudero Zurita",
            "Pedro Hernández Sanz",
            "Beatriz López Roca",
            "Mohamed García Laguna",
            "Manuel Garcés Martínez",
            "José Ventura Rebollo",
            "Manuel Silva Mora",
            "Adrián Duran Sánchez",
            "Manuel Morales Martin",
            "Daniel Tarín Sandoval",
            "Víctor Rayo Martínez",
            "Margarita Gallardo Cubas",
            "Carmen Herranz Hernández",
            "Ana María Calero Pérez",
            "Juana Mangas Araujo",
            "María Concepción Solís Couto",
            "Beatriz Morales Jiménez",
            "Antonio Blanco Serrano",
            "Francisco Javier Santana Ruiz",
            "Josefa Romo Martínez",
            "Antonia Blanco Marina",
            "Dolores Ávila Puertas",
            "Rafael Aranda Rodríguez",
            "Juan Antonio Martínez Corrales",
            "Víctor Vargas Cañas",
            "Emilia Moreno Hernández",
            "Marta Pastor Mateo",
            "José Antonio Aparicio Castro",
            "María Carmen Pérez Díaz",
            "Silvia Alcalá López",
            "Pedro Reina Zamorano",
            "Juan Antonio Rojo Pérez",
            "María Carmen López Vargas",
            "Raquel Cruz Ojeda",
            "Jesús Pérez Casanova",
            "María Carmen Canet Oliver",
            "Miguel Ángel Santamaría Segura",
            "Francisco Manuel Sáez Cantón",
            "Antonio Cortes Oliva",
            "Raúl Bonilla Fajardo",
            "Rubén Jareño Martínez",
            "Jorge Monreal Bermúdez",
            "Laura Duran Gómez",
            "Antonia Sánchez Mestre",
            "Carlos Martin Barea",
            "Nuria García Aguilar",
            "José Antonio Álvarez Maldonado",
            "Rafael García Castillo",
            "Francisco Úbeda Luengo",
            "María José Domínguez Martin",
            "Antonio Merino Osuna",
            "Albert Diez Sánchez",
            "Nuria Pérez Sala",
            "Iñigo Vidal Agustín",
            "Jesús Andrés Rivera",
            "Marc García Yagüe",
            "José Manuel Pelayo Madrid",
            "Isabel María Flores Sevillano",
            "Rubén Roda Vilalta",
            "Jesús Martin Iglesias",
            "José Mayordomo Moreno",
            "Rosa Benítez Castellano",
            "Raquel Martínez Fuertes",
            "Laura Gutiérrez Elvira",
            "María Carmen Sánchez Marín",
            "Cristina Sánchez Climent",
            "David Arcos Rivero",
            "Juan Hernández Blázquez",
            "Manuel González Solé",
            "Antonio Mejías Sola",
            "Esther Martin Sanabria",
            "Pino Ledesma Fraile",
            "Laura Martínez Martínez",
            "José Antonio Espinosa Jiménez",
            "José Rivas Sánchez",
            "Raquel De Diego Ferrero",
            "Javier Campo González",
            "Carlos García Bermúdez",
            "Rocío Vila Martin",
            "Francisco Martínez Sánchez",
            "Mónica Castro Vicent",
            "Ana María Ferrándiz Martínez",
            "Pablo Arenas Melian",
            "María José Gallego García",
            "Fernando Jove Tejero",
            "Antonio Marrero Pujol",
            "María Carmen Escobar Pérez",
            "Ana Isabel Benítez Segura",
            "Manuela Madueño Poveda",
            "Isabel Vera Peinado",
            "José Luis Sobrino Parra",
            "Xavier Martínez Delgado",
            "Ana María Márquez González",
            "Nuria Jurado González",
            "José Ramos Gil",
            "Carmen María Hidalgo Ordoñez",
            "Alejandro Nogales Matas",
            "Nuria Cano Rodríguez",
            "Lucia Hernández Reyes",
            "Santiago Mediavilla Núñez",
            "Carlos Jiménez Silva",
            "Roberto Rodríguez Martos",
            "Josefa Clavería Martínez",
            "Iván Álvarez Martí",
            "María Dolores López Hernández",
            "David Romero Menéndez",
            "Óscar González Guerrero",
            "Alberto Pérez Galindo",
            "Manuel Molina Sola",
            "María Villar Torres",
            "Roberto Costa Franco",
            "Javier Martin Aranda",
            "Vicente Aguilera García",
            "Raquel López Ramos",
            "Daniel Criado Pérez",
            "José Polo Capdevila",
            "José Manuel Pérez Burgos",
            "Juana Barroso Fuentes",
            "Joan Blanco Guerrero",
            "Enrique Carmona Mercado",
            "Juan Manuel Quintana Montero",
            "Ana María Calleja Martínez",
            "Juan Antonio Esteban Martin",
            "María Carmen Mosquera Miranda",
            "José Luis Moyano Sánchez",
            "Marta Garrido García",
            "Lucia Martin Jiménez",
            "Luis Moreno Sánchez",
            "Enrique Pérez Fernández",
            "María Rojo Ramos",
            "Lucia Cuadrado García",
            "José Luis Román García",
            "Adrián Olmos Rodríguez",
            "Alejandro Contreras Costas",
            "Manuel Rodríguez Ramos",
            "Josefa Lázaro Martínez",
            "Josefa Corral Hernández",
            "Óscar Pascual Fernández",
            "Javier García Herranz",
            "María Carmen García Ezquerra",
            "María Dorta Popa",
            "Albert Medina Moya",
            "Manuel Domenech Torres",
            "Mercedes Montaño Diez",
            "Manuela García Martínez",
            "José Antonio Morente Torres",
            "Juan Carlos Martínez Duarte",
            "María Jesús González Sánchez",
            "Francisco Javier Fernández Rodríguez",
            "Araceli Álvarez Suarez",
            "Ana María Gómez Romero",
            "Sonia Sebastián Ruiz",
            "Francisca López Rodríguez",
            "Antonio Hernández Pomares",
            "Ramón Hernández Vega",
            "Ángela Andrés Dimitrov",
            "Jesús Sánchez Casado",
            "Antonio Pérez Calle",
            "Sara Rodríguez Ramos",
            "Manuel Peñaranda García",
            "Andrés Sánchez Gómez",
            "María Cuevas Pérez",
            "María Mar García Conejo",
            "Manuel García Acevedo",
            "Cristina Riquelme Araujo",
            "María José Mayoral Martin",
            "Juan Antonio Martin Rodríguez",
            "María Barragán Salgueiro",
            "Juan Rey González",
            "Álvaro Muñoz García",
            "Dolores Asensio Gallego",
            "Álvaro Polo Padilla",
            "María Carmen Redondo Asensi",
            "Marina Nieto Mínguez",
            "María Carmen García Rosario",
            "Alejandro Rodríguez Ferrer",
            "José Antonio Fernández Cobo",
            "Francisco Hernández Costa",
            "Eduardo Montalbán Belda",
            "Miquel Wang Tovar",
            "Isabel Rincón Llorca",
            "Francisco Baeza Rodríguez",
            "María Ángeles Guerrero Gómez",
            "Ángeles Reyes García",
            "Ana María Ivanova Vázquez",
            "Sara Ledo Ramos",
            "Amaia Reyes Medina",
            "Diego Giménez Pueyo",
            "Adrián Carrascosa Solano",
            "Manuel Madrigal Sanz",
            "María Carmen Serban López",
            "José Antonio Gómez Salazar",
            "Fernando García Soares",
            "Miguel Muñoz Sánchez",
            "José Manuel Guerrero Conde",
            "Carlos Villarroya Huertas",
            "Manuel Ferrero Mayol",
            "Daniel Marín Ropero",
            "Cristina Alcalá Fernández",
            "Joaquín García Rodríguez",
            "Jesús Sáez Montenegro",
            "María Jesús Ponce Nava",
            "Josep Heredia Rodríguez",
            "José López Medina",
            "José Manuel Reyes Chamorro",
            "María Reina Martínez",
            "María Alberola García",
            "Antonio Catalán Llorente",
            "Francisco Vila Martin",
            "Rafael Macías Vila",
            "Lucia Rosillo Sánchez",
            "María Dolores Martínez Benítez",
            "Javier Losada Sánchez",
            "María Carmen Sánchez Quesada",
            "Jordi Castillo Plasencia",
            "María Ángeles García Martin",
            "Alfonso Patiño Mansilla",
            "Xavier Cámara Hernández",
            "Raúl Palomino Gomis",
            "Juana Pérez Rodríguez",
            "María Carmen Alonso Fernández",
            "María Carmen Mendoza Moya",
            "Esther Mera Martínez",
            "Xavier Pascual García",
            "Manuel Ortega Céspedes",
            "Jorge Páez Sancho",
            "José María Ibarra Ramírez",
            "Igor Pérez Benavides",
            "Carmen Prieto Medina",
            "Jaime Vila Vadillo",
            "Pedro Rueda Montes",
            "José Moreno Rubio",
            "Joaquín Ortega Vicent",
            "Laura Pallares Rodríguez",
            "Laura Mamani Fernández",
            "José Antonio Grande Grande",
            "Carmelo Rodríguez Martínez",
            "Juan Jiménez Andreu",
            "Antoni Duarte Bohórquez",
            "Francisco Oliva Figueroa",
            "Montserrat Arjona García",
            "María Amparo Jerez Gómez",
            "Ramón López Cámara",
            "María Pilar Porcel López",
            "Juan Cerezo Moraleda",
            "Rosario García Morcillo",
            "Ana Puerta Martínez",
            "Juan Carlos Ramírez Pérez",
            "Irene Iglesias Alcalá",
            "Rafael Santiago Rodríguez",
            "Rubén Rodríguez Gomis",
            "Jesús María Navarro Mata",
            "Víctor Alcalde Venegas",
            "Amaia Vargas Estévez",
            "Francisco Lozano Alcón",
            "Manuela Mercado Callejas",
            "Pedro José Pérez Sanz",
            "Andrés Ramos Juan",
            "Carmen Sancho Ortiz",
            "Teresa García Gonzalo",
            "Jesús Sánchez Calderón",
            "Mercedes Rodríguez Rodríguez",
            "María Ángeles Climent Molero",
            "Pino Cao Stoica",
            "Jesús Piñeiro Limón",
            "Fernando Rodríguez García",
            "Elena González Rodríguez",
            "Francisco Hernández Ferrer",
            "Rafael Rodríguez López",
            "Jesús Royo Pereira",
            "Laura Torres Cózar",
            "María Victoria Rueda Zorrilla",
            "David Font Puche",
            "Óscar Mármol Jiménez",
            "Salvador Ferrando Estrada",
            "María Dolores Collantes Ayllón",
            "Laura Segarra Martin",
            "María Roldan Vargas",
            "Iñigo Villarreal García",
            "David Navarro Martínez",
            "María Carmen Pérez Silva",
            "Francisco Javier Dopico Fuster",
            "Francisco Javier Saavedra Ruiz",
            "María Tejeda Sánchez",
            "María Núñez Catalá",
            "Irene Fortes García",
            "Manuel Morales Campos",
            "María Cuenca Sánchez",
            "Laura Escrivá Medina",
            "Pedro Huertas Martínez",
            "Francisco Molero Carballo",
            "David Ramos López",
            "Juan Flores Rúa",
            "Iván Millán Fernández",
            "Manuel Sainz Carmona",
            "Sandra Del Valle Molina",
            "José Antonio Mateo Machuca",
            "Jorge Romero Rodríguez",
            "Paula Ropero Vicent",
            "José Luis Pueyo Torrico",
            "María Isabel Ramos Peinado",
            "Juana Carracedo Palacios",
            "Sara Santana Castello",
            "Carmen Delgado Suarez",
            "Antonia Prieto Sierra",
            "Ainhoa Benito Méndez",
            "María Pilar Carrasco Sánchez",
            "Ana Muriel Guardiola",
            "Lucia Aller Teruel",
            "Rosa María Arenas Lorenzo",
            "Manuel Rodríguez Couto",
            "Francisco Javier Montes Sala",
            "José Antonio López Polo",
            "Antonio Jesús Vidal Artero",
            "José López De la Rosa",
            "Juan Hernández Toledo",
            "María Rosales Porras",
            "Alejandro Serrano Alcalde",
            "María Carmen Sánchez Tormo",
            "Miguel Sánchez Sierra",
            "Antonio Martínez López",
            "José Luis Domínguez Arcas",
            "José Manuel Moreno Gómez",
            "María Dolores Gutiérrez Pires",
            "Elena Briones Núñez",
            "María Carmen Matute Carreras",
            "Paula Querol Jiménez",
            "Laura Peláez Santos",
            "Juan José Ojeda Garrido",
            "José Martin García",
            "Alberto Domingo Márquez",
            "Francisca Vega Sánchez",
            "Luis Hernando Martin",
            "Antonio Fornes Peña",
            "María Cabrera Díaz",
            "José María Luna Soler",
            "Marta Sánchez Maldonado",
            "Concepción Pastor Mosquera",
            "Rubén Montesinos Morato",
            "Luis López Gómez",
            "Alfonso García López",
            "Luis Ordoñez Segovia",
            "María Jesús Riera López",
            "María Serrano Hernández",
            "María Carmen Moreno Díaz",
            "María Dolores Martínez Iñigo",
            "Carmen Rodríguez Marcos",
            "Antonio Tejedor Torres",
            "Lucia Ruiz Ortiz",
            "Julio Salazar García",
            "Dolores Maya García",
            "Manuel Díaz Mateos",
            "Manuel Font Ramos",
            "Isabel Cabrera Sánchez",
            "María Ángeles Granado López",
            "José María Cánovas Martínez",
            "Enrique Muñoz Rodríguez",
            "Luis Mozo Plaza",
            "José Bermejo Labrador",
            "Carlos Ruiz Oviedo",
            "José María López Gil",
            "Mónica Díaz Mateos",
            "Francisco José Hernández Blanco",
            "Carlos Holgado Carbajo",
            "Antonio Soler Vargas",
            "Francisco Serna Fernández",
            "Juan José Haro Martínez",
            "María Ruz González",
            "Antonio Catalá Zurita",
            "José Ortiz Baeza",
            "Carmen Martínez Corpas",
            "Manuel Gómez Pérez",
            "Susana Sánchez Muñoz",
            "Inmaculada Salvador Triguero",
            "Alejandro García Barrio",
            "Iván Rojo Martin",
            "Beatriz Gil Rodríguez",
            "María José Abad López",
            "Fernando Herrero Flores",
            "Francisco Javier Jiménez Cano",
            "Alejandro Felipe García",
            "José Luis Pizarro Serrano",
            "Paula Rico Coello",
            "Asier Salcedo Pérez",
            "Vicente Alcaraz Santamaría",
            "José María Cerezo Mendieta",
            "María Rosa Martínez Heredia",
            "Rocío Vílchez Montero",
            "María Esteban Sala",
            "Albert González Frutos",
            "María Luisa Larios Monfort",
            "María González Martin",
            "Antonio Miguel Palacios",
            "Miguel Ángel Sánchez Mesa",
            "Elena González Díaz",
            "Alicia Muñoz García",
            "Jesús Alonso Soler",
            "Mercedes Piera Moreno",
            "Concepción Alonso Quintero",
            "José Luis Fernández Rojas",
            "Manuel Márquez San Martin",
            "Juana Ye Rodríguez",
            "María Carmen Mora Álamo",
            "José Luis Ruiz Rodríguez",
            "José Ramón Guillen Ramos",
            "David Ramos Pérez",
            "José López Bravo",
            "Juan Manuel Serrano Ferreras",
            "Antonio Sánchez Coronado",
            "Ana Castilla Prieto",
            "José Manuel Ramos Fernández",
            "María Molla Borrego",
            "David Sánchez Castro",
            "María Ángeles Rodríguez Jiménez",
            "Iván Bueno De León",
            "María Dolores Sánchez Pérez",
            "Rosa María Macia Morales",
            "Josefa Parejo Venegas",
            "Ángel García Ferreira",
            "Jon Fernández Díaz",
            "José Vicente Sánchez Torres",
            "María Teresa Gómez González",
            "Miguel Ángel Rodríguez Fernández",
            "Rosa Aznar Álvarez",
            "Rosa María Mateu Herrero",
            "Francisca Peris Gonzalo",
            "Yolanda Alcocer Diz",
            "Sara Uribe Asensio",
            "Juan Manuel Mohamed Sesma",
            "Carlos Negrín Doval",
            "Francisco Javier Herrero Blanch",
            "Francisco Javier Rodríguez Amorós",
            "Pedro Bouzas Sánchez",
            "Jesús Martínez Navarro",
            "José Torrecilla Medrano",
            "Dolores Herrero Bonilla",
            "José Luis Castro Rodríguez",
            "María Carmen Sevilla Herrera",
            "Julia Ruiz Jorge",
            "Óscar Rodríguez Tejero",
            "María Abad Pérez",
            "Andrea Salcedo López",
            "Marta Fernández Losa",
            "Sergio Jover Peláez",
            "María Jesús Ripoll Sánchez",
            "Sara Alarcón Garrido",
            "Carmen Fernández Quiroga",
            "José María Catalán Pérez",
            "María Jesús López Obregón",
            "Miguel Castro Martínez",
            "Teresa Fernández Costa",
            "Silvia Muñiz Jones",
            "Raquel Cano Redondo",
            "Manuel Herrero Rodríguez",
            "María Pilar Pérez Ballesta",
            "María Carmen Gutiérrez Soriano",
            "Silvia Martínez Martin",
            "Raúl Ramírez Melgar",
            "Rafael Sánchez Rodríguez",
            "María Campo Paredes",
            "Cristina Carrillo Salmerón",
            "Raquel Yagüe Rodríguez",
            "Miguel Ángel Marques Fernández",
            "Daniel Rodríguez Sánchez",
            "Javier Lorenzo León",
            "Ángel Márquez Pina",
            "María Teresa Abadía Bonilla",
            "María Ángeles Egea Vera",
            "Álvaro Villar Cruz",
            "Juan Manuel Díaz Sánchez",
            "Ángel Aguirre Moreno",
            "Juan José Sainz Torres",
            "Ángel Costas García",
            "Concepción Reyes Rodríguez",
            "Manuel Del Valle González",
            "José Luis Espinosa Santamaría",
            "Vicente Barbera Martin",
            "Marina Alonso Jiménez",
            "Jesús García Bautista",
            "David González Gallego",
            "Javier Fortuny Hermosilla",
            "Teresa Zamora Peña",
            "José Luis Martínez García",
            "Eduardo Fernández Mendoza",
            "Elena Mateos Pérez",
            "María Josefa Sánchez Aparicio",
            "Alejandro Vázquez López",
            "Juan José Rodríguez Sánchez",
            "Adrián López Marín",
            "Paula Martínez Calvo",
            "Francisco Díaz Bernat",
            "Francisco Alonso Sanz",
            "Juan Carlos Morales Navarro",
            "Marta Merchán Molero",
            "Lucia Capdevila Moya",
            "Francisco José Galán Vázquez",
            "Rafael Calvo Diez",
            "Alicia Perales Varo",
            "Lucia Busto Miguel",
            "Beatriz López Díaz",
            "Rosa María Ruiz Sánchez",
            "Manuel Cid Silvestre",
            "Paula Gómez Rodrigues",
            "Ana Belén Cortes Fernández",
            "Paula Cánovas Matas",
            "Lucia Benito Meneses",
            "Miguel Vicente Torres",
            "Isabel Rico Serrano",
            "Manuel López Requena",
            "Pilar Cáceres Del Toro",
            "Raquel Pérez González",
            "María Pilar Suarez Rodríguez",
            "José Morales León",
            "Lucia Domínguez Alba",
            "Tomas De la Cruz Hernández",
            "Manuel Rodríguez Barbero",
            "María Luisa Díaz Rojo",
            "Lucia Iglesias Solorzano",
            "Lucia Alemany Real",
            "Alejandro López Moreno",
            "Adrián López Domínguez",
            "Manuel Correa García",
            "Antonia Vidal Rodríguez",
            "Antonio Manrique Galán",
            "María Rojas Salmerón",
            "Teresa Díaz Martínez",
            "Fernando De la Fuente Domenech",
            "Carmen Sánchez García",
            "David González Barrero",
            "José Manuel Martin López",
            "Óscar Alcalá Chamorro",
            "Josefa Alemán Pérez",
            "Rosa Navarro Mármol",
            "Miguel Ángel Morillas Gutiérrez",
            "María Simón Cortes",
            "María Pilar Rodríguez Del Rosario",
            "Enrique Palomo Tovar",
            "Ana Martínez Castillejo",
            "Concepción Torres Duran",
            "José Antonio Salgado Jimeno",
            "Ángel San Emeterio Velasco",
            "Laura Gómez Montero",
            "Sara Del Castillo Leiva",
            "María Amparo Suarez Olea",
            "Teresa Fernández Amorós",
            "Elena Molina Serrano",
            "Alejandro Crespo Martin",
            "Laura Martin Pérez",
            "Sonia Santos Salcedo",
            "José Antonio Carmona Ortiz",
            "Jesús Jaime Rodríguez",
            "María Teresa Tirado Vidal",
            "Ángeles Giménez Martin",
            "Antonio Rodríguez Pérez",
            "Joan Dorado Vázquez",
            "Lucia Triviño Puig",
            "María Teresa Esteve Alonso",
            "Manuel Velasco Gil",
            "Silvia Martin Gil",
            "Josep Jiménez Bas",
            "Antonio Batista Santos",
            "María Luisa González Soriano",
            "José Luis Sánchez Muñoz",
            "Daniel Blanco Cuenca",
            "María Carmen Cruzado Coloma",
            "José Antonio Camacho Delgado",
            "Manuela Carvajal Gallego",
            "Joaquín López Fernández",
            "José María Medina Egea",
            "Jesús María Llop Álvarez",
            "Jorge Garrido Albaladejo",
            "María Luisa Lago Fernández",
            "Juan Manuel Egea Muñoz",
            "Antonio Jiménez Barragán",
            "Sonia Fuentes Fernández",
            "Rafael Carro Suarez",
            "José Martínez Jiménez",
            "Carlos Lorente Lujan",
            "Isabel Ferreira Vidal",
            "José Rodríguez Del Moral",
            "Juan Rodríguez Granados",
            "Miguel Ángel Arias Rubio",
            "María Rosa Viñas Blanch",
            "Josefa Clavero Trujillo",
            "Antonio Martínez Jiménez",
            "María Carmen Bueno Hoyos",
            "Salvador Velasco Jiménez",
            "Rafael Morilla Romero",
            "Mónica Laguna Casillas",
            "José Antonio Martin Gómez",
            "Carlos Moreno Piñero",
            "Ana Granados Manrique",
            "María Ángeles Mohamed López",
            "María Isabel Calle Castro",
            "Sergi Gea Martin",
            "María Jesús Castro Chaparro",
            "Sergio Rivera Gil",
            "Ángeles García Cacho",
            "Antonio Gómez Otero",
            "Felipe Castro Gutiérrez",
            "María Jesús García Ferrero",
            "José Manuel Carrillo Contreras",
            "Carlos Trillo Rodríguez",
            "Oriol Ivars González",
            "Jordi Martínez Domínguez",
            "Sebastián Ruz Robles",
            "Carmen Medina Gallego",
            "Laura Martin Martínez",
            "Juan Carlos González Martin",
            "José Luis González Canet",
            "Josefa Sánchez Sánchez",
            "José Antonio Canosa Ortega",
            "Alfonso Blanes Real",
            "José Luis Linares Tormo",
            "María Ángeles Matute Martin",
            "María Jaume Lozano",
            "María Elena De Castro Calvo",
            "Rafael Sánchez Del Pino",
            "Elena De la Hoz Venegas",
            "María Elvira Hidalgo",
            "María Dolores Castro Tovar",
            "Pablo Delgado García",
            "Pilar Sánchez Martin",
            "Carlos García Pina",
            "Vicente García González",
            "Silvia Bravo Salvador",
            "María Vieira Cavero",
            "Juan Jiménez Franco",
            "Iván Molto Bilbao",
            "Alberto Ramos Verdú",
            "Jesús Lozano Fernández",
            "María Pilar Martínez Aliaga",
            "José Luis Pérez Alcaraz",
            "Ángel Blanco Mariscal",
            "Albert Moreno Mestres",
            "Xabier García Granados",
            "Raquel Benavent Jiménez",
            "Juan Castillo Calzada",
            "Rosa María Fernández Cuesta",
            "Antonia Santamaría Jiménez",
            "María Ángeles González Ortiz",
            "Alberto Muñoz Pinto",
            "José María González Del Castillo",
            "Iker Marín Ricart",
            "Manuela Pérez Garrido",
            "Santiago Rodenas Guijarro",
            "Álvaro Díaz Rodríguez",
            "Francisco Martin Sastre",
            "María Camacho Martínez",
            "José Luis Fortuny Nieto",
            "Enrique González Montes",
            "Andrés Ramírez Santos",
            "Antonio Hernández Gamiz",
            "Juana García Cantón",
            "Isabel Marín Guerrero",
            "María Pilar Martínez Alvarado",
            "José Recio Martínez",
            "María Carmen Fernández Martin",
            "Santiago González Del Rio",
            "Javier Duran Noguera",
            "Paula Arjona Monedero",
            "Alejandro Saborido Rubio",
            "Manuel Gómez Madrid",
            "Rafael Vázquez Jiménez",
            "Pedro Adán Rodríguez",
            "José Antonio Pérez Navarro",
            "María Carmen Rodríguez García",
            "Lucia Blanco Vázquez",
            "María Pelegrín García",
            "Javier Prieto Álvarez",
            "Antonio Sánchez González",
            "José Luis Cifuentes Rodríguez",
            "Rafael Sánchez Sánchez",
            "Alicia Hernández Dos Santos",
            "Alejandro González Blanco",
            "José Manuel Montoya Jaén",
            "María Dolores Guerra Dalmau",
            "José Fabregat Herranz",
            "Fernando Peralta López",
            "José López García",
            "Francisco Sánchez Sánchez",
            "Antonio Simón López",
            "José Navarro Chamorro",
            "Javier Silva Muñoz",
            "Pedro Millán Lara",
            "Miguel Castro Fernández",
            "José Estepa Fernández",
            "Santiago Sáez Barbero",
            "Ana María Mateu Duarte",
            "Isabel Guerrero Camarero",
            "Ricardo Bañon González",
            "María Rosa López Muñoz",
            "Pilar Salgado Arjona",
            "María Gonzalo Muñoz",
            "Asier Aguilera Rosas",
            "Manuel Gálvez Velasco",
            "Roberto De la Iglesia Calvo",
            "Adrián Colomer Velázquez",
            "Manuel Martínez Rey",
            "María Candelaria Blanco Sánchez",
            "Antonio Carrera Campos",
            "Manuel Bolívar Escalante",
            "Antonio Andreu Oviedo",
            "María Carmen López Cánovas",
            "Alberto Escolar Martínez",
            "Patricia Cobos Ferreira",
            "Manuel Rus Batalla"
        };
        private int horasSimuladas;
        private int codSimulacion;
        private int codEscenario;
        private string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["bdContext"].ConnectionString;
        public LogicaSimulacion(int horas)
        {
            this.horasSimuladas = horas;
        }

        public bool iniciarSimulacion(int cantidadDeSimulaciones)
        {
            bool respuesta = false;
            using (MySqlConnection conexion = new MySqlConnection(conStr))
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    using (var bd = new bdContext(conexion, false))
                    {
                        bd.Database.UseTransaction(transaccion);
                        //Creacion de registro en tabla escenario
                        bd.Escenarios.Add(new Escenario()
                        {
                            fecha = DateTime.Now
                        });
                        bd.SaveChanges();
                        int codigoEscenario = bd.Escenarios.OrderByDescending(es => es.cod_escenario).First().cod_escenario;
                        codEscenario = codigoEscenario;

                        for (int j = 0; j < cantidadDeSimulaciones; j++)
                        {
                            //Creacion del registro en tabla simulacion
                            bd.Simulaciones.Add(new Simulacion()
                            {
                                indice_simulacion = j+1,
                                horas_simulacion = horasSimuladas,
                                fecha = DateTime.Now,
                                cod_escenario = codigoEscenario
                            });
                            bd.SaveChanges();

                            //Obtencion del cod_simulacion creado
                            int codigoSimulacion = bd.Simulaciones.OrderByDescending(s => s.cod_simulacion).First().cod_simulacion;
                            codSimulacion = codigoSimulacion;

                            //Creacion de los registros en tabla hora
                            var horasGeneradas = generarHorasSimulacion(codigoSimulacion);
                            foreach (Hora_simulacion item in horasGeneradas)
                            {
                                bd.Horas_simulacion.Add(item);
                                bd.SaveChanges();
                            }

                            //Obtencion de los codigos de hora creados
                            var codigosHora = bd.Horas_simulacion.OrderByDescending(hs => hs.cod_hora).Select(hs => hs.cod_hora).Take(horasSimuladas).ToArray();
                            codigosHora.Reverse();

                            //Creacion de los registros para la tabla producto_simulacion (Se obtienen de la tabla de productos. Es practicamente una copia)
                            var productos = bd.Productos.Where(p => p.habilitado).ToList();

                            foreach (var item in productos)
                            {
                                bd.Productos_simulacion.Add(new Producto_simulacion()
                                {
                                    cod_producto = item.cod_producto,
                                    cod_simulacion = codigoSimulacion,
                                    precio_compra = item.precio_compra,
                                    precio_venta = item.precio_venta,
                                    stock = item.stock,
                                    tiempo_preparacion = item.tiempo_preparacion
                                });
                                bd.SaveChanges();
                            }

                            //Creacion de los registros en la tabla clientes
                            var clientes = generarClientesPorHora(generarNumeroClientesPorHora(), codigosHora);
                            foreach (var clientesPorHora in clientes)
                            {
                                foreach (var item in clientesPorHora)
                                {
                                    bd.Clientes.Add(item);
                                    bd.SaveChanges();
                                }
                            }

                            //Creacion de registros en la tabla detalle_venta


                            List<int> codigosClientesIngresados = new List<int>();
                            
                            foreach (var item in codigosHora)
                            {
                                var cods = bd.Clientes.Where(c => c.cod_hora == item).Select(m => m.cod_cliente).ToList();
                                foreach (var codCliente in cods)
                                {
                                    codigosClientesIngresados.Add(codCliente);
                                }
                            }


                            var codigosProductosSimulacion = bd.Productos_simulacion.Where(ps => ps.cod_simulacion == codigoSimulacion)
                                .Select(a => a.cod_prod_simulacion).ToArray();

                            var semilla = Environment.TickCount;
                            var random = new Random(semilla);

                            foreach (var item in codigosClientesIngresados)
                            {
                                for (int i = 0; i < random.Next(0, 4); i++)
                                {
                                    int codigoProductoRandom = codigosProductosSimulacion[random.Next(0, codigosProductosSimulacion.Length - 1)];

                                    var prodSimulacion = bd.Productos_simulacion.Find(codigoProductoRandom);

                                    if (prodSimulacion.stock != 0) 
                                    { 
                                        bd.Detalles_venta.Add(new Detalle_venta()
                                        {
                                            cod_cliente = item,
                                            cod_prod_simulacion = codigoProductoRandom
                                        });
                                        bd.SaveChanges();

                                        prodSimulacion.stock--;

                                        bd.Entry(prodSimulacion).State = System.Data.Entity.EntityState.Modified;
                                        bd.SaveChanges();
                                    }

                                }
                            }

                            //Calculo de los tiempos de servicio para los clientes

                            var clientesParaEdicion = bd.Clientes.Where(c => c.hora_simulacion.cod_simulacion == codSimulacion).OrderBy(m => m.cod_cliente).ToList();

                            var tiempoDePreparacionParaSuma = bd.Detalles_venta.Where(ps => ps.producto_simulacion.cod_simulacion == codSimulacion).Select(a => new
                            {
                                cod_cliente = a.cod_cliente,
                                tiempo = a.producto_simulacion.tiempo_preparacion
                            }).ToList();

                            if (clientesParaEdicion.Count != 0)
                            {
                                double suma = 0.5;
                                int codClientteAuxiliar = clientesParaEdicion[0].cod_cliente;
                                foreach (var cliente in clientesParaEdicion)
                                {
                                    suma = 0.5;
                                    foreach (var item in tiempoDePreparacionParaSuma)
                                    {
                                        if (item.cod_cliente == cliente.cod_cliente)
                                        {
                                            suma += item.tiempo;
                                        }
                                    }
                                    cliente.tiempo_servicio = suma;
                                }
                            }

                            foreach (var item in clientesParaEdicion)
                            {
                                bd.Entry(item).State = System.Data.Entity.EntityState.Modified;
                                bd.SaveChanges();
                            }
                        }

                    }
                    transaccion.Commit();
                    respuesta = true;
            }
                catch (Exception)
            {
                transaccion.Rollback();
                respuesta = false;
            }
        }

            return respuesta;
        }

        private List<Hora_simulacion> generarHorasSimulacion(int cod_simulacion)
        {
            List<Hora_simulacion> horas = new List<Hora_simulacion>();
            for (int i = 0; i < horasSimuladas; i++)
            {
                horas.Add(new Hora_simulacion()
                {
                    hora = i + 1,
                    cod_simulacion = cod_simulacion
                });
            }

            return horas;
        }

        private int[] generarNumeroClientesPorHora()
        {
            var semilla = Environment.TickCount;
            var random = new Random(semilla);

            int[] clientesPorHora = new int[horasSimuladas];

            for (int i = 0; i < horasSimuladas; i++)
            {
                var valor = random.Next(0, 35);
                clientesPorHora[i] = valor;
            }
            
            return clientesPorHora;
        }

        
        private List<Cliente>[] generarClientesPorHora(int[] numeroClientesPorHora, int[] codigos_hora)
        {
            //codigos_hora.Reverse();
            List<Cliente>[] listaClientes = new List<Cliente>[numeroClientesPorHora.Length];
            List<Cliente> clientes = new List<Cliente>();
            var semilla = Environment.TickCount;
            var random = new Random(semilla);
            for (int i = 0; i < numeroClientesPorHora.Length; i++)
            {
                listaClientes[i] = new List<Cliente>();
                for (int j = 0; j < numeroClientesPorHora[i]; j++)
                {
                    listaClientes[i].Add(new Cliente()
                    {
                        cod_hora = codigos_hora[i],
                        nombre = nombresAleatorios[random.Next(0, nombresAleatorios.Length - 1)],
                    });
                    
                }
            }
            return listaClientes;
        }

        //public bool verificarStock(int codProducto)
        //{
        //    bool stockCorrecto = false;
        //    using (MySqlConnection conexion = new MySqlConnection(conStr))
        //    {
        //        conexion.Open();
        //        MySqlTransaction transaccion = conexion.BeginTransaction();

        //        try
        //        {
        //            using (var bd = new bdContext(conexion, false))
        //            {
        //                bd.Database.UseTransaction(transaccion);

        //                var prodSimulacion = bd.Productos_simulacion.Find(codProducto);

        //                stockCorrecto = prodSimulacion.stock != 0;
        //                prodSimulacion.stock = stockCorrecto ? prodSimulacion.stock - 1 : 0;

        //                bd.Entry(prodSimulacion).State = System.Data.Entity.EntityState.Modified;
        //                bd.SaveChanges();

        //            }

        //            transaccion.Commit();
        //        }
        //        catch (Exception)
        //        {
        //            transaccion.Rollback();
        //            stockCorrecto = false;
        //        }
        //    }
        //    return stockCorrecto;
        //}
        
        public int getCodigoSimulacion()
        {
            return this.codSimulacion;
        }

    }
}