# Заголовок проекта

Итоговая работа по МДК.11.01
// UserProfileScreen.kt
import androidx.compose.foundation.layout.*
import androidx.compose.material3.Button
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp

@Composable
fun UserProfileScreen() {
    Column(
        modifier = Modifier
            .fillMaxWidth()
            .padding(16.dp),
        verticalArrangement = Arrangement.spacedBy(8.dp)
    ) {
        Text(
            text = "Профиль пользователя",
            style = MaterialTheme.typography.headlineSmall
        )
        
        Text("Логин: [Ваш логин]")
        Text("Имя: [Ваше имя]")
        Text("Возраст: [Ваш возраст]")
        Text("Страна: [Ваша страна]")
        Text("О себе: [Информация о себе]")
        
        Button(onClick = { /* Действие при клике на кнопку "Назад" */ }) {
            Text("Назад")
        }
    }
}

@Preview
@Composable
fun UserProfileScreenPreview() {
    UserProfileScreen()
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
