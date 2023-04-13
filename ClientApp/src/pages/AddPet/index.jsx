import Navbar from "../../components/Layouts/Navbar";
import { Information } from "../../components/common";
import { Subtitle } from "../../components/common";
import { ContentImage } from "../../components/ContentImage";
import { Input } from "../../components/common";
import { CheckBox } from "../../components/common";
import { Button } from "../../components/common";
import { Title, Description } from "../../components/common";

export function AddPet() {
  return (
    <>
      <header>
        <Navbar />
      </header>
      <main>
        <section className="m-4">
          <Information className="border-0 p-0">
            <Title content="Agregar mascota" />
            <Description content="Agrega algunos datos para iniciar el seguimiento médico de tu mascota." />
          </Information>
        </section>
        <section className="m-4">
          <Subtitle content="Imagen" />
          <ContentImage />
        </section>
        <section className="m-4">
          <Subtitle content="Nombre" />
          <Input type="text" placeholder="Nombre de tu mascota" />
        </section>
        <section className="m-4">
          <Subtitle content="Especie" />
          <Input type="text" placeholder="Elegir" />
        </section>
        <section className="m-4">
          <Subtitle content="Raza" />
          <Input type="text" placeholder="Raza de tu mascota" />
        </section>
        <section className="m-4">
          <Subtitle content="Peso" />
          <Input type="text" placeholder="Peso de tu mascota" />
        </section>
        <section className="m-4">
          <Subtitle content="Fecha de nacimiento" />
          <Input type="date" />
        </section>
        <section className="m-4">
          <Subtitle content="Sexo" />
          <CheckBox
            label1="Hembra"
            label2="Macho"
            label3="No lo sé"
            checked={true}
          />
        </section>
        <section className="m-4">
          <Subtitle content="Castración" />
          <CheckBox label1="Si" label2="No" label3="No lo sé" checked={true} />
        </section>
        <section className="m-4">
          <Button className="w-full" text="Agregar mascota" />
        </section>
      </main>
    </>
  );
}
