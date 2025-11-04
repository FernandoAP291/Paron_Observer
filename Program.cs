using Paron_Observer;

Youtuber canal = new Youtuber();

Subscriptor s1 = new Subscriptor("Brisa");
Subscriptor s2 = new Subscriptor("Jeremy");
Subscriptor s3 = new Subscriptor("carlos");

canal.agregarSubs(s1);
canal.agregarSubs(s2);
canal.agregarSubs(s3);

canal.publicar("Como tener un punto extra para la t3");
canal.publicar("Como jugar en clases");
