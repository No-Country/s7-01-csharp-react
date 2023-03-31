import { useState, useEffect } from "react";

const App = () => {

    const [forecast, setForecast] = useState([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        fetch("weatherforecast")
            .then((response) => {
                return response.json()
            }
            ).then((array) => {
                setLoading(false)
                setForecast(array);
            });
    }, []);



    return (
        <div class="w-full">
            <nav class="mx-auto flex justify-between">
                <div class="text-2xl">
                    <img src="" alt="Logo" />
                </div>
                <div class="text-[20px] bg-luis">Hamburguesa</div>
            </nav>
            <div class="mt-6 p-2">
                <h3 class="text-[16px] font-semibold">Mis Mascotas(5)</h3>
            </div>
            <div class="mt-6 flex w-full justify-around md:bg-black">
                <div></div>
                <div class="h-20 w-20 rounded-full border-4 bg-green-500 hover:border-purple-700 hover:scale-125"></div>
                <div class="h-20 w-20 rounded-full border bg-green-500 hover:border-purple-700"></div>
                <div class="h-20 w-20 rounded-full border bg-green-500 hover:border-purple-700"></div>
                <div class="h-20 w-20 rounded-full border bg-green-500 hover:border-purple-700"></div>
            </div>

            <h2>
                {loading ?
                    <>Loading data  </>

                    : <div>
                        <ul>
                            {forecast.map(f => <li key={f.date}>{f.date} - {f.temperatureC} - {f.summary} </li>)}
                        </ul>
                    </div>
                }
            </h2>
        </div>
    );
};

export default App;
