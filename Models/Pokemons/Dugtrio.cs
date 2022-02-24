using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dugtrio Specie to store common natural stats of every {'abilities': ['sand-veil', 'arena-trap', 'sand-force'], 'base_experience': 149, 'height': 7, 'id': 51, 'moves': ['scratch', 'cut', 'sand-attack', 'body-slam', 'take-down', 'double-edge', 'growl', 'hyper-beam', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'bide', 'fury-swipes', 'rest', 'rock-slide', 'tri-attack', 'slash', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'hidden-power', 'sunny-day', 'rock-smash', 'uproar', 'facade', 'secret-power', 'astonish', 'rock-tomb', 'sand-tomb', 'aerial-ace', 'natural-gift', 'sucker-punch', 'night-slash', 'earth-power', 'giga-impact', 'shadow-claw', 'mud-bomb', 'stone-edge', 'captivate', 'stealth-rock', 'hone-claws', 'sludge-wave', 'round', 'echoed-voice', 'bulldoze', 'rototiller', 'confide'], 'name': 'dugtrio', 'stats': {'hp': 35, 'attack': 100, 'defense': 50, 'special-attack': 50, 'special-defense': 70, 'speed': 120}, 'types': ['ground'], 'weight': 333, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 50, 'color': 'brown', 'shape': 'heads', 'habitat': 'cave', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ダグトリオ', 'roomaji': 'Dugtrio', 'ko': '닥트리오', 'zh-Hant': '三地鼠', 'fr': 'Triopikeur', 'de': 'Digdri', 'es': 'Dugtrio', 'it': 'Dugtrio', 'en': 'Dugtrio', 'ja': 'ダグトリオ', 'zh-Hans': '三地鼠'}, 'genera': {'ja-Hrkt': 'もぐらポケモン', 'ko': '두더지포켓몬', 'zh-Hant': '鼴鼠寶可夢', 'fr': 'Pokémon Taupe', 'de': 'Maulwurf', 'es': 'Pokémon Topo', 'it': 'Pokémon Talpa', 'en': 'Mole Pokémon', 'ja': 'もぐらポケモン', 'zh-Hans': '鼹鼠宝可梦'}}
	public class SpecieDugtrio : PokemonSpecie
	{
#nullable enable
		private static SpecieDugtrio? _instance = null;
#nullable restore
        public static SpecieDugtrio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDugtrio();
                }
                return _instance;
            }
        }

		public SpecieDugtrio() : base(
			"Dugtrio",
			35, // HPs
			100, 50, // Attack & Defense
			50, 70, // Special Attack & Defense
			120			
		) {}
	}


	//Dugtrio Pokemon Class
	public class Dugtrio : Pokemon
	{

		public Dugtrio(string nickname, int level)
		: base(
				51,
				SpecieDugtrio.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dugtrio(int level)
		: base(
				51,
				SpecieDugtrio.Instance, // Pokemon Specie
				"Dugtrio", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dugtrio() : base(
			51,
			SpecieDugtrio.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}