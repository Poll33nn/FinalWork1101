# Заголовок проекта

Итоговая работа по МДК.11.01
// LoginScreen.kt
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
fun LoginScreen() {
    Column(
        modifier = Modifier
            .fillMaxWidth()
            .padding(16.dp),
        verticalArrangement = Arrangement.spacedBy(8.dp)
    ) {
        Text(
            text = "Экран авторизации",
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
        
        Row(
            modifier = Modifier.fillMaxWidth(),
            horizontalArrangement = Arrangement.spacedBy(8.dp)
        ) {
            Button(onClick = { /* Действие при клике на кнопку "Войти" */ }) {
                Text("Войти")
            }
            
            Button(onClick = { /* Действие при клике на кнопку "Зарегистрироваться" */ }) {
                Text("Зарегистрироваться")
            }
        }
    }
}

@Preview
@Composable
fun LoginScreenPreview() {
    LoginScreen()
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
