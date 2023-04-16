import React from "react";
import { PawPrint } from "@phosphor-icons/react";
import imgPerro from "../../assets/images/imgPerro.png";
import imgPerro2 from "../../assets/images/imgPerro2.png";
import imgPerro3 from "../../assets/images/imgPerro3.png";

// Rutas
import { Link } from "react-router-dom";

const ShowPets = () => {
  return (
    <div className="container mx-auto">
      <div className="mt-4 p-2 bg-gray-50">
        <h3 className="ml-2 text-[18px] font-bold">Mis Mascotas(5)</h3>
      </div>
      <div className="mt-6 flex w-full justify-around">
        <Link to={`/app/add-mascot`}>
          <div className="relative">
            <div className="h-16 w-16 rounded-full border bg-gray-100 hover:border-purple-700">
              <PawPrint size={28} className="absolute left-4 top-4" />
            </div>
            <p className="text-center">Agregar</p>
            <p className="text-center">Mascota</p>
          </div>
        </Link>

        <Link to={`/app/petInfo`}>
          <div className="">
            <img
              src={imgPerro}
              alt="perro"
              className="h-16 w-16 rounded-full hover:scale-110 hover:duration-500 hover:transition-all cursor-pointer"
            />
            <p className="text-center">{"Mascota"}</p>
          </div>
        </Link>

        <div className="">
          <img
            src={imgPerro2}
            alt="perro"
            className="h-16 w-16 rounded-full hover:scale-110 hover:duration-500 hover:transition-all cursor-pointer"
          />
          <p className="text-center">{"Mascota"}</p>
        </div>
        <div className="">
          <img
            src={imgPerro3}
            alt="perro"
            className="h-16 w-16 rounded-full hover:scale-110 hover:duration-500 hover:transition-all cursor-pointer"
          />
          <p className="text-center">{"Mascota"}</p>
        </div>
      </div>
      <div />
    </div>
  );
};

export default ShowPets;
