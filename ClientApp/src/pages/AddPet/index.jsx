import Navbar from "../../components/Layouts/Navbar";
import { Information } from "../../components/common";
import { Subtitle } from "../../components/common";

export function AddPet() {
  return (
    <>
      <header>
        <Navbar />
      </header>
      <main>
        <section className="m-4">
          <Information
            className="border-0 p-0"
            title="Agregar mascota"
            description="Agrega algunos datos para iniciar el seguimiento médico de tu mascota. "
          />
        </section>
        <section className="m-4">
          <Subtitle content="Imagen" />
        </section>
      </main>
    </>
  );
}
