import React from "react";
import {
  Clock,
  MagnifyingGlass,
  MapPin,
  WhatsappLogo,
} from "@phosphor-icons/react";
import perro from "../../assets/images/perro.png";

const MiniClinic = ({nombre}) => {

  return (
    <div className="w-[394px] h-[149px] flex flex-col gap-4 justify-center items-center text-center rounded-xl bg-white p-4">
      <div className="flex ml-4">
        <div className="w-14 h-14 rounded-full flex mt-2 ">
          <img src={perro} alt="perrito" />
        </div>
        <div className="ml-4 text-center mt-2">
          <p className="font-bold">{nombre}</p>
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
