# Заголовок проекта

Итоговая работа по МДК.11.01
// RegistrationScreen.kt
import androidx.compose.foundation.layout.*
import androidx.compose.material3.Button
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp

@Composable
fun RegistrationScreen() {
    Column(
        modifier = Modifier
            .fillMaxWidth()
            .padding(16.dp),
        verticalArrangement = Arrangement.spacedBy(8.dp)
    ) {
        Text(
            text = "Экран регистрации",
            style = MaterialTheme.typography.headlineSmall
        )
        
        OutlinedTextField(
            value = "",
            onValueChange = {},
            label = { Text("Логин") }
        )
        
        OutlinedTextField(
            value = "",
            onValueChange = {},
            label = { Text("Пароль") }
        )
        
        OutlinedTextField(
            value = "",
            onValueChange = {},
            label = { Text("Подтверждение пароля") }
        )
        
        OutlinedTextField(
            value = "",
            onValueChange = {},
            label = { Text("Номер телефона") }
        )
        
        OutlinedTextField(
            value = "",
            onValueChange = {},
            label = { Text("Email") }
        )
        
        OutlinedTextField(
            value = "",
            onValueChange = {},
            label = { Text("Возраст") }
        )
        
        Button(onClick = { /* Действие при клике на кнопку "ОК" */ }) {
            Text("ОК")
        }
    }
}

@Preview
@Composable
fun RegistrationScreenPreview() {
    RegistrationScreen()
}

## Начало работы

Для начала работы нужно получить доступ к БД, и запустить FragrantWorld.sln

### Необходимые условия

Необходимо Windows 10/11

### Установка

Взломать мой компьютер, получа доступ к БД

Открыть FragrantWorld.sln

И наслаждаться программой

## Авторы

* **Druzhinin Denis** - *Final Work* 
