import React from 'react';

const Auth = () => {
    var tokenKey = "accessToken";
    const testClickSend = async () =>{
        const response = await fetch("https://localhost:5001/login", {
                method: "POST",
                headers: { "Accept": "application/json", "Content-Type": "application/json" },
                body: JSON.stringify({
                    email: document.getElementById("login").value,
                    password: document.getElementById("password").value
                })
            });
            // если запрос прошел нормально
            if (response.ok === true) {
                // получаем данные
                const data = await response.json();
                // изменяем содержимое и видимость блоков на странице
                document.getElementById("userName").innerText = data.username;
                document.getElementById("userInfo").style.display = "block";
                document.getElementById("loginForm").style.display = "none";
                // сохраняем в хранилище sessionStorage токен доступа
                sessionStorage.setItem(tokenKey, data.access_token);
            }
            else  // если произошла ошибка, получаем код статуса
                console.log("Status: ", response.status);
    }

    const getDataSend = async () => {
        const token = sessionStorage.getItem(tokenKey);
            // отправляем запрос к "/data
            const response = await fetch("https://localhost:5001/data", {
                method: "GET",
                headers: {
                    "Accept": "application/json",
                    "Authorization": "Bearer " + token  // передача токена в заголовке
                }
            });
    }
    return (
        <main>
            <div className="container">
                <div className="col-lg-8 mx-auto">
                    <form>
                        <label htmlFor='login'>Логин</label>
                        <input type='text' id='login'/>
                        <label htmlFor='password'>Пароль</label>
                        <input type='password' id='password'/>
                        <input type="submit" id="submitLogin" onClick={testClickSend} value="Логин" />
                        <input type="submit" id="getData" onClick={getDataSend} value="Получить данные" />
                    </form>
                </div>
            </div>
        </main>
    );
};

export default Auth;