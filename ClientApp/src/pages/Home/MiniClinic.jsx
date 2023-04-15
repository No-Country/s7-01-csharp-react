import React from "react";
import {
    Clock,
    MagnifyingGlass,
    MapPin,
    WhatsappLogo,
  } from "@phosphor-icons/react";
  import perro from "../../assets/images/perro.png";

const MiniClinic = () => {
  return (
    <>
      <div className="mt-8 ml-2 container w-[394px] h-[149px] flex text-center rounded-xl bg-white ">
        <div className="flex ml-4">
          <div className="w-14 h-14 rounded-full flex mt-2 ">
            <img src={perro} alt="perrito" />
          </div>
          <div className="ml-4 text-center mt-2">
            <p className="font-bold">Nombre de la clínica</p>
            <div className="flex gap-2 ml-2">
              <Clock className="text-gray-100" />
              <p className="text-gray-100 ">LUN A VIE. DE 08:00 a 19:00</p>
            </div>
            <div className="flex gap-2 ml-2">
              <MapPin className="text-gray-100" />
              <p className="text-gray-100">DIRECCIÓN</p>
            </div>
          </div>
        </div>
      </div>
      <button className="flex  gap-2 rounded-xl border-2  px-2 py-4 translate-x-24 -translate-y-16">
        <WhatsappLogo size={20} className="" />
        <p className=" font-bold">Enviar Whatsapp</p>
      </button>
    </>
  );
};

export default MiniClinic;
