import React from 'react'
import { Clock, MagnifyingGlass, MapPin, WhatsappLogo } from '@phosphor-icons/react'
import perro from "../../assets/images/perro.png"

const ClinicCard = () => {
    return (
        <>
            <div className="mt-8 px-2">
                <h3 className="mt-4 font-bold">Clinicas Veterinarias</h3>
                <div className="mt-4 w-[328px] h-[40px] rounded-xl  flex items-center gap-2">
                    <MagnifyingGlass size={20} />
                    <input type="text" className=" w-[280px] h-[21px]  rounded-md p-4 " placeholder="Buscar Veterinarias" />
                </div>
            </div>
            <div className="mx-auto grid grid-cols-2 gap-4 justify-between mt-4">
                <button className="bg-primary-150 rounded-xl px-2 py-1">
                    Cirugía
                </button>
                <button className="bg-primary-150 rounded-xl px-2 py-1">
                    Vacunas
                </button>
                <button className="bg-primary-150 rounded-xl px-2 py-1">
                    Desparacitacion
                </button>
                <button className="bg-primary-150  rounded-xl px-2 py-1">
                    Atención
                </button>
            </div>
            <div className='mt-8 ml-2 container w-[328px] h-[149px] flex text-center rounded-xl '>
                <div className='flex ml-4'>
                    <div className='w-14 h-14 rounded-full flex '>
                        <img src={perro} alt="perrito" />
                    </div>
                    <div className='ml-4 text-center'>
                        <p className='font-bold'>Nombre de la clinica</p>
                        <div className='flex gap-2 ml-2'>
                            <Clock className='text-gray-100' />
                            <p className='text-gray-100 '>LUN A VIE. DE 08:00 a 19:00</p>
                        </div>
                        <div className='flex gap-2 ml-2'>
                            <MapPin className='text-gray-100' />
                            <p className='text-gray-100'>DIRECCION</p>
                        </div>
                    </div>
                </div>
                
            </div>
            <button className='flex  gap-2 rounded-xl border-2  px-2 py-4 translate-x-24 -translate-y-14'>
                <WhatsappLogo size={20} className=''/>
                <p className=' font-bold'>Enviar Whatsapp</p>
            </button>
            


        </>
    )
}

export default ClinicCard