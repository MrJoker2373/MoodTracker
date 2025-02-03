namespace MoodTracker.Client
{
    public class MenuSwitcher
    {
        private readonly List<Menu> _allMenus;
        private readonly Color _defaultColor;
        private readonly Color _selectedColor;
        private Menu _currentMenu;

        public MenuSwitcher(IEnumerable<Menu> allMenus, Color defaultColor, Color selectedColor)
        {
            _allMenus = allMenus.ToList();
            _defaultColor = defaultColor;
            _selectedColor = selectedColor;

            for (int i = 0; i < _allMenus.Count; i++)
            {
                int index = i;
                _allMenus[i].Hide(_defaultColor);
                _allMenus[i].Triggered += () => Switch(index);
            }

            _currentMenu = _allMenus[0];
            _currentMenu.Show(_selectedColor);
        }

        private void Switch(int index)
        {
            _currentMenu.Hide(_defaultColor);
            _currentMenu = _allMenus[index];
            _currentMenu.Show(_selectedColor);
        }
    }
}