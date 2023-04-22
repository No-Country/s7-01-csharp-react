import React from "react";
import { MagnifyingGlass } from "@phosphor-icons/react";
import MiniClinic from "./MiniClinic";
import { useAllClinics } from "../../hooks/useAllClinics";

// rutas
import { Link } from "react-router-dom";

const ClinicCard = () => {
  const { clinicas, services } = useAllClinics();
<<<<<<< HEAD
  console.log(clinicas);
  return (
    <div className="container mx-auto">
      <div className="mt-8 px-2 ">
=======
  // console.log(clinicas);
  return (
    <div className="container mx-auto my-8 ">
      <div className="px-2 ">
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
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
<<<<<<< HEAD
      <div className="grid grid-cols-2 md:flex md:flex-row md:justify-start  gap-4 justify-between mt-4 container">
        {services.map((service) => (
          <button
            key={service.id}
            className="bg-primary-150 rounded-xl px-2 py-1"
          >
            {service.nombre}
          </button>
        ))}
      </div>

      <div className="container mt-8 mx-auto h-screen  grid gap-4 gap-x-16 justify-center md:grid-cols-2 lg:grid-cols-3">
        {clinicas.map((clinica) => (
          <Link key={clinica.id} to={`app/clinic/${clinica.id}`}>
            <MiniClinic nombre={clinica.nombre} />
          </Link>
=======
      <div className="container mt-8 mx-auto grid gap-4 gap-x-16 justify-center md:grid-cols-2 lg:grid-cols-3">
        {clinicas.map((clinica) => (
          <MiniClinic key={clinica.id} clinica={clinica} />
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
        ))}
      </div>
    </div>
  );
};

export default ClinicCard;
