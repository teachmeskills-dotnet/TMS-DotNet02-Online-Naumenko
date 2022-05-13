import React from 'react';

const Login = () => {
    return (
        <main>
            <div className="container">
                <div className="col-lg-8 mx-auto">
                    <form>
                        <label htmlFor='login'>Логин</label>
                        <input type='text' id='login'/>
                        <label htmlFor='password'>Пароль</label>
                        <input type='password' id='password'/>
                        <input type="submit" id="submitLogin" value="Логин" />
                        <input type="submit" id="getData" value="Получить данные" />
                    </form>
                </div>
            </div>
        </main>
    );
};

export default Login;