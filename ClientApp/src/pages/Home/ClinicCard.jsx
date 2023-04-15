import React from "react";
import {
  Clock,
  MagnifyingGlass,
  MapPin,
  WhatsappLogo,
} from "@phosphor-icons/react";
import perro from "../../assets/images/perro.png";
import MiniClinic from "./MiniClinic";

const ClinicCard = () => {
  return (
    <div className="container mx-auto">
      <div className="mt-8 px-2 ">
        <h3 className="mt-4 font-bold">Clínicas Veterinarias</h3>
        <div className="mt-4 w-[328px] h-[40px] md:w-[900px] md:h-[21px] rounded-xl  flex items-center gap-2">
          <MagnifyingGlass size={20} />
          <input
            type="text"
            className=" w-[280px] h-[21px] md:w-[900px] md:h-[21px] rounded-md p-4 "
            placeholder="Buscar Veterinarias"
          />
        </div>
      </div>
      <div className="grid grid-cols-2 md:flex md:flex-row md:justify-start  gap-4 justify-between mt-4 container">
        <button className="bg-primary-150 rounded-xl px-2 py-1">Cirugía</button>
        <button className="bg-primary-150 rounded-xl px-2 py-1">Vacunas</button>
        <button className="bg-primary-150 rounded-xl px-2 py-1">
          Desparasitación
        </button>
        <button className="bg-primary-150  rounded-xl px-2 py-1">
          Atención
        </button>
        <button className="bg-primary-150 rounded-xl px-2 py-1 hidden md:flex">Microchips</button>
        <button className="bg-primary-150 rounded-xl px-2 py-1 hidden md:flex">Más Filtros</button>
      </div>
      <div className="grid grid-cols-1 md:grid md:grid-cols-2">

        <MiniClinic />
        <MiniClinic />
        <MiniClinic />
        <MiniClinic />

      </div>


    </div>
  );
};

export default ClinicCard;
