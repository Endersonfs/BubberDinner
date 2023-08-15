<div align="center">

<!-- <img src="assets/BuberBreakfastUiUx.png" alt="drawing" width="1000"/> -->

 [![GitHub Stars](https://img.shields.io/github/stars/amantinband/buber-breakfast.svg)](https://github.com/amantinband/buber-breakfast/stargazers) [![GitHub license](https://img.shields.io/github/license/amantinband/buber-breakfast)](https://github.com/amantinband/buber-breakfast/blob/main/LICENSE)

---

### This is the source code of the [CRUD REST API from scratch using .NET 7 tutorial](https://github.com/Endersonfs/BubberDinner)

</div>

# Usage

Simply `git clone https://github.com/Endersonfs/BubberDinner` and `dotnet run --project .\BuberDinner.Api\`.

# API Definition


## BuberDinner

### Register Request

```js
POST /{{host}}/Auth/register
```

```json
{
    "firstname": "first Name",
    "lastname": "Last Name",
    "email": "email@email.com",
    "password": "Password12345!"
}
```

### Register Response

```js
201 Created
```

```yml
Location: POST /{{host}}/Auth/register
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "firstname": "First Name",
    "lastname": "Last Name",
    "email": "email@email.com",
    "token": "eyhjT23.....worom239olo"
}
```


### Login Request

```js
POST /{{host}}/Auth/login
```

```json
{
    "email": "email@email.com",
    "password": "Password12345!"
}
```

### Login Response

```js
201 Created
```

```yml
Location: {{host}}/auth/login
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "firstname": "First Name",
    "lastname": "Last Name",
    "email": "email@email.com",
    "token": "eyhjT23.....worom239olo"
}
```

<!-- 
## Get Breakfast

### Get Breakfast Request

```js
GET /breakfasts/{{id}}
```

### Get Breakfast Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Update Breakfast

### Update Breakfast Request

```js
PUT /breakfasts/{{id}}
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
``` -->
<!-- 
### Update Breakfast Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Breakfasts/{{id}}
```

## Delete Breakfast

### Delete Breakfast Request

```js
DELETE /breakfasts/{{id}}
```

### Delete Breakfast Response

```js
204 No Content
``` -->

<!-- # Credits

- [ErrorOr](https://github.com/amantinband/error-or) - A simple, fluent discriminated union of an error or a result. -->

# VSCode Extensions

- [VSCode Rest Client](https://github.com/Huachao/vscode-restclient) - REST Client allows you to send HTTP request and view the response in Visual Studio Code directly.

<!-- - [VSCode Markdown Preview Enhanced](https://github.com/shd101wyy/vscode-markdown-preview-enhanced) - Markdown Preview Enhanced is an extension that provides you with many useful functionalities for previewing markdown files. -->

# Disclaimer

This is an educational project. The source code is licensed under the MIT license.

# License

This project is licensed under the terms of the [MIT](https://github.com/amantinband/buber-breakfast/blob/main/LICENSE) license.