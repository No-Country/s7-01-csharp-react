import React from "react";
import {
  Clock,
  MagnifyingGlass,
  MapPin,
  WhatsappLogo,
} from "@phosphor-icons/react";
import perro from "../../assets/images/perro.png";

const MiniClinic = ({ clinica }) => {
  // console.log(clinica.direccion.calle);
  // console.log(clinica);

  return (
    <div className="w-[394px] h-[149px] flex flex-col gap-4 justify-center items-center text-center rounded-xl bg-white p-4">
      <div className="flex ml-4">
        <div className="w-16 h-16 rounded-full flex mt-2 border-2 border-black">
          <img
            className="rounded-full object-cover object-center"
            src={clinica.logoURI}
            alt="perrito"
          />
        </div>
        <div className="ml-4 text-center mt-2">
          <p className="font-bold">{clinica.nombre}</p>
          <div className="flex gap-2 ml-2">
            <Clock className="text-gray-100" />
            <p className="text-gray-100 ">LUN A VIE. DE 08:00 a 19:00</p>
          </div>
          <div className="flex gap-2 ml-2">
            <MapPin className="text-gray-100" />
            <p className="text-gray-100">{`${clinica.direccion.calle}-${clinica.direccion.numero}`}</p>
          </div>
        </div>
      </div>
      <button className="px-4 py-2 bottom-3 left-32 border border-gray-300 rounded-xl ">
        <div className="flex gap-2">
          <WhatsappLogo size={20} className="text-black" />
          <p className="text-black">Whatsapp</p>
        </div>
      </button>
    </div>
  );
};

export default MiniClinic;
