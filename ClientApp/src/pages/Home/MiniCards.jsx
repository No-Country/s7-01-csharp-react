import React from "react";
import { CalendarBlank, Syringe } from "@phosphor-icons/react";

const MiniCards = () => {
  return (
    <>
      <div className="mt-6 p-2 hidden  ">
        <h3 className="ml-2 text-[18px] font-bold ">
          Proximos Recordatorios (3)
        </h3>
      </div>
      <div className="mt-4 w-[314px] h-[113px] rounded bg-white  hidden md:block ">
        <div className="ml-2 flex flex-row gap-1 relative">
          <div className="h-16 w-16 mt-2 rounded-full border bg-secondary-50 hover:border-purple-700 ">
            <Syringe size={30} className="left-4 bottom-4  absolute" />
          </div>
          <div className="mt-4">
            <p className="text-center">{"Nombre de mascota"}</p>
            <p className="mt-2 text-center">{"Nombre del recordatorio"}</p>
          </div>
          <div className="ml-4">
            <input
              type="checkbox"
              className="h-4 w-4 rounded mt-4 border-gray-300 bg-gray-100 text-blue-600 focus:ring-2 focus:ring-blue-500 dark:border-gray-600 dark:bg-gray-700 dark:ring-offset-gray-800 dark:focus:ring-blue-600"
            />
          </div>
        </div>
        <div className="mt-4 flex gap-4 p-2">
          <CalendarBlank size={20} />
          <p className="text-center text-gray-500">Miercoles 18 de abril</p>
        </div>
      </div>
    </>
  );
};

export default MiniCards;
