# My_ShootingGame_HW4_KU
 
201911194 유광채
 2023-2학기 건국대학교 게임프로그래밍(3175) 과제 4번 슈팅게임 제출물입니다.

*New Features
- 게임 환경에서 앞뒤좌우 총 4방향에 벽을 설치, Static Collider로 설정.
- HW3 프로젝트의 기존 건물에도 Box Collider를 통해 Static Collider로 설정.
- 충돌 체크, 관련 설명을 위한 큐브, 구 오브젝트를 설치
- GameManager의 instance, UnityEvent 사용 및 Win, Lose 조건 판단 기능 추가.

*필수 사항
- 메인 캐릭터의 움직임에 AddRelativeForce, AddRelativeTorque를 통해 물리 기반의 움직임을 구현했습니다.
- 메인 캐릭터에 capsule collider와 rigidbody를 통해 collision 기능을 추가했습니다.
- 게임 환경에서 캐릭터 뒤쪽에 초록색 Lose 큐브를 두어 플레이어가 지켜야 할 base로 만들었습니다.
- 게임 환경에서 보라색 공이 초록색 큐브에 닿았을 때 CharacterColliderCheck 함수의 onWin, onLose 이벤트가 발생하도록 했습니다.
- onWin, onLose 이벤트에는 GameManager에 의해 각각 WinScene, LoseScene으로 이동하는 함수가 AddListener에 의해 호출됩니다.
- 강의 시간에 배운 5가지 종류의 Collider를 5개의 큐브 (검정, 파랑, 빨강, 흰색, 노랑)에 각각 구현했습니다.
- Layer Collision Matrix를 통해 보라색 공 (Ball Layer)과 위에서 설명한 5개의 큐브 (Enemy Layer)가 서로 충돌하지 않도록 했습니다.
- Layer Collision Matrix를 통해 플레이어 (Player Layer)가 초록색 Base 큐브 (Base Layer)와 충돌하지 않도록 했습니다.
