import Navbar from "../../components/Layouts/Navbar";
import { Information } from "../../components/common";
import { Subtitle } from "../../components/common";
import { ContentImage } from "../../components/ContentImage";
import { Input } from "../../components/common";
import { Radio } from "../../components/common";
import { Button } from "../../components/common";
import { Title, Description, Select } from "../../components/common";

export function AddPet() {
  return (
    <>
      <header>
        <Navbar />
      </header>
      <main className="grid place-items-center h-screen">
        <section className="m-4 md:w-2/4">
          <Information className="border-0 p-0">
            <Title className="text-lg" content="Agregar mascota" />
            <Description
              className="text-gray-150 text-sm"
              content="Agrega algunos datos para iniciar el seguimiento médico de tu mascota."
            />
          </Information>
        </section>
        <section className="m-4 md:w-2/4">
          <Subtitle content="Imagen (opcional)" />
          <ContentImage />
        </section>
        <section className="m-4 md:w-2/4">
          <Subtitle content="Nombre" />
          <Input type="text" placeholder="Nombre de tu mascota" />
        </section>
        <section className="m-4 md:w-2/4">
          <Subtitle content="Especie" />
          <Select />
        </section>
        <section className="m-4 md:w-2/4">
          <Subtitle content="Raza" />
          <Input type="text" placeholder="Raza de tu mascota" />
        </section>
        <section className="m-4 md:w-2/4">
          <Subtitle content="Peso" />
          <Input type="text" placeholder="Peso de tu mascota" />
        </section>
        <section className="m-4 md:w-2/4">
          <Subtitle content="Fecha de nacimiento" />
          <Input type="date" />
        </section>
        <section className="m-4 md:w-2/4">
          <Subtitle content="Sexo" />
          <Radio label1="Hembra" label2="Macho" label3="Otro" name="sexo" />
        </section>
        <section className="m-4 md:w-2/4">
          <Subtitle content="Castración" />
          <Radio label1="Si" label2="No" label3="No lo sé" name="castracion" />
        </section>
        <section className="m-4 md:w-2/4 mb-7">
          <Button
            className="w-full text-base text-white bg-primary-100"
            text="Agregar mascota"
          />
        </section>
      </main>
    </>
  );
}
