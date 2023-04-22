import { Clock, MapPin } from "@phosphor-icons/react";

<<<<<<< HEAD
export function DataClinic({ className, name }) {
  return (
    <div className="flex flex-col">
      <div className="mb-2">
        <h1 className="text-[#010B1D] not-italic font-medium text-2xl">
          {/* {name} */}xzxzxzx
=======
export function DataClinic({ className, name, direccion }) {
  return (
    <div className="flex flex-col">
      <div className="mb-2">
        <h1
          className={`text-[#010B1D] not-italic font-medium text-2xl ${className}`}
        >
          {name}
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
        </h1>
      </div>

      <div className="flex justify-start items-center gap-1.5 mb-2 text-sm text-[#888888]">
        <Clock className="block" size={13} />
        <p className="text-[#888888] not-italic font-normal text-xs uppercase">
          LUN. A VIE. DE 08:00 A 19:00
        </p>
      </div>
      <div className="flex justify-start items-center gap-1.5 mb-2 text-sm text-[#888888]">
        <MapPin size={13} />
        <p className="text-[#888888] not-italic font-normal text-xs uppercase">
<<<<<<< HEAD
          dirección
=======
          {/* {`${direccion && direccion.calle}-`} */}
          {direccion &&
            `${direccion.calle}-${direccion.numero}-${direccion.ciudad}-${direccion.pais}`}
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
        </p>
      </div>
    </div>
  );
}
