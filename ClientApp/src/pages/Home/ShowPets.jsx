import React from "react";
import { PawPrint } from "@phosphor-icons/react";

const ShowPets = () => {
  return (
    <>
      <>
        <div className="mt-4 p-2 bg-gray-50">
          <h3 className="ml-2 text-[18px] font-bold">Mis Mascotas(5)</h3>
        </div>
        <div className="mt-6 flex w-full justify-around">
          <div className="relative">
            <div className="h-16 w-16 rounded-full border bg-gray-100 hover:border-purple-700">
              <PawPrint size={28} className="absolute left-4 top-4" />
            </div>
            <p className="text-center">Agregar</p>
            <p className="text-center">Mascota</p>
          </div>
          <div className="">
            <div className="h-16 w-16 rounded-full border bg-slate-300 hover:border-purple-700"></div>
            <p className="text-center">{"Mascota"}</p>
          </div>
          <div className="">
            <div className="h-16 w-16 rounded-full border bg-slate-300 hover:border-purple-700"></div>
            <p className="text-center">{"Mascota"}</p>
          </div>
          <div className="">
            <div className="h-16 w-16 rounded-full border bg-slate-300 hover:border-purple-700"></div>
            <p className="text-center">{"Mascota"}</p>
          </div>
          <div className="">
            <div className="h-16 w-16 rounded-full border bg-slate-300 hover:border-purple-700"></div>
            <p className="text-center">{"Mascota"}</p>
          </div>
        </div>
      </>
    </>
  );
};

export default ShowPets;
