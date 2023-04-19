import React from 'react'
import imgPerro4 from "../../assets/images/imgPerro4.png"
import { LockKey } from '@phosphor-icons/react'

const ThirdBlock = () => {
    return (
        <div className='mt-4 block md:grid md:grid-cols-4 md:justify-between md:gap-x-16 md:gap-y-2'>
            <div className='w-[330px] h-[215px] mt-4 flex justify-center flex-col text-center rounded-xl md:w-[330px] md:h-[215px]   bg-white mx-auto'>
                <img src={imgPerro4} alt="fotoperro" className='w-12 h-12 mx-auto' />
                <p>{"{Nombre}"}</p>
                <p>{"{Raza}"}</p>
                <button className='w-[191px] h-[48px] mt-2 mx-auto px-4 py-3 rounded-md border-primary-100 border bg-gray-50 flex justify-center gap-2'>
                    <LockKey size={20} className="text-primary-100"/>
                    <p className='text-primary-100'>Solicitar Acceso</p>
                </button>
            </div>
            <div className='w-[330px] h-[215px] mt-4 flex justify-center flex-col text-center rounded-xl md:w-[330px] md:h-[215px]   bg-white mx-auto'>
                <img src={imgPerro4} alt="fotoperro" className='w-12 h-12 mx-auto' />
                <p>{"{Nombre}"}</p>
                <p>{"{Raza}"}</p>
                <button className='w-[191px] h-[48px] mt-2 mx-auto px-4 py-3 rounded-md border-primary-100 border bg-gray-50 flex justify-center gap-2'>
                    <LockKey size={20} className="text-primary-100"/>
                    <p className='text-primary-100'>Solicitar Acceso</p>
                </button>
            </div>
            <div className='w-[330px] h-[215px] mt-4 flex justify-center flex-col text-center rounded-xl md:w-[330px] md:h-[215px]   bg-white mx-auto'>
                <img src={imgPerro4} alt="fotoperro" className='w-12 h-12 mx-auto' />
                <p>{"{Nombre}"}</p>
                <p>{"{Raza}"}</p>
                <button className='w-[191px] h-[48px] mt-2 mx-auto px-4 py-3 rounded-md border-primary-100 border bg-gray-50 flex justify-center gap-2'>
                    <LockKey size={20} className="text-primary-100"/>
                    <p className='text-primary-100'>Solicitar Acceso</p>
                </button>
            </div>
            <div className='w-[330px] h-[215px] mt-4 flex justify-center flex-col text-center rounded-xl md:w-[330px] md:h-[215px]   bg-white mx-auto'>
                <img src={imgPerro4} alt="fotoperro" className='w-12 h-12 mx-auto' />
                <p>{"{Nombre}"}</p>
                <p>{"{Raza}"}</p>
                <button className='w-[191px] h-[48px] mt-2 mx-auto px-4 py-3 rounded-md border-primary-100 border bg-gray-50 flex justify-center gap-2'>
                    <LockKey size={20} className="text-primary-100"/>
                    <p className='text-primary-100'>Solicitar Acceso</p>
                </button>
            </div>
            <div className='w-[330px] h-[215px] mt-4 flex justify-center flex-col text-center rounded-xl md:w-[330px] md:h-[215px]   bg-white mx-auto'>
                <img src={imgPerro4} alt="fotoperro" className='w-12 h-12 mx-auto' />
                <p>{"{Nombre}"}</p>
                <p>{"{Raza}"}</p>
                <button className='w-[191px] h-[48px] mt-2 mx-auto px-4 py-3 rounded-md border-primary-100 border bg-gray-50 flex justify-center gap-2'>
                    <LockKey size={20} className="text-primary-100"/>
                    <p className='text-primary-100'>Solicitar Acceso</p>
                </button>
            </div>
           
        </div>
    )
}

export default ThirdBlock