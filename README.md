# My_ShootingGame_HW4_KU
 
201911194 유광채
 2023-2학기 건국대학교 게임프로그래밍(3175) 과제 4번 슈팅게임 제출물입니다.

*New Features
- 마우스 우클릭 시, 무기가 변경되고 화면에 현재 발사되는 무기 이름 명시.
- 좌우 방향 움직임 시, 사용자의 transform.rotation 값이 그 방향대로 바뀌어 자연스럽게 회전하도록 함.
- WASD, 키보드 방향키 모두 사용하여 움직일 수 있도록 함. (좌/우 : W, ← / D, →) (위/아래 W, ↑ / S, ↓)

*필수 사항
- 메인 캐릭터의 움직임에 AddRelativeForce, AddRelativeTorque를 통해 물리 기반의 움직임을 구현했습니다.
- 메인 캐릭터에 capsule collider와 rigidbody를 통해 collision 기능을 추가했습니다.
- 게임 환경에서 캐릭터 뒤쪽에 초록색 Lose 큐브를 두어 플레이어가 지켜야 할 base로 만들었습니다.
- 게임 환경에서 보라색 공이 초록색 큐브에 닿았을 때 CharacterColliderCheck 함수의 onWin, onLose 이벤트가 발생하도록 했습니다.
- onWin, onLose 이벤트에는 GameManager에 의해 각각 WinScene, LoseScene으로 이동하는 함수가 AddListener에 의해 호출됩니다.
- 강의 시간에 배운 5가지 종류의 Collider를 5개의 큐브 (검정, 파랑, 빨강, 흰색, 노랑)에 각각 구현했습니다.
- Layer Collision Matrix를 통해 보라색 공 (Ball Layer)과 위에서 설명한 5개의 큐브 (Enemy Layer)가 서로 충돌하지 않도록 했습니다.
- Layer Collision Matrix를 통해 플레이어 (Player Layer)가 초록색 Base 큐브 (Base Layer)와 충돌하지 않도록 했습니다.
