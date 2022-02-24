using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sandshrew Specie to store common natural stats of every {'abilities': ['sand-veil', 'sand-rush'], 'base_experience': 60, 'height': 6, 'id': 27, 'moves': ['scratch', 'swords-dance', 'cut', 'sand-attack', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'poison-sting', 'submission', 'counter', 'seismic-toss', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'bide', 'swift', 'skull-bash', 'fury-swipes', 'rest', 'rock-slide', 'super-fang', 'slash', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'detect', 'sandstorm', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'magnitude', 'dynamic-punch', 'rapid-spin', 'iron-tail', 'metal-claw', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'brick-break', 'knock-off', 'secret-power', 'crush-claw', 'rock-tomb', 'sand-tomb', 'aerial-ace', 'mud-shot', 'covet', 'gyro-ball', 'natural-gift', 'fling', 'poison-jab', 'night-slash', 'x-scissor', 'earth-power', 'shadow-claw', 'rock-climb', 'captivate', 'stealth-rock', 'hone-claws', 'round', 'chip-away', 'bulldoze', 'rototiller', 'confide'], 'name': 'sandshrew', 'stats': {'hp': 50, 'attack': 75, 'defense': 85, 'special-attack': 20, 'special-defense': 30, 'speed': 40}, 'types': ['ground'], 'weight': 120, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'yellow', 'shape': 'upright', 'habitat': 'rough-terrain', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'サンド', 'roomaji': 'Sand', 'ko': '모래두지', 'zh-Hant': '穿山鼠', 'fr': 'Sabelette', 'de': 'Sandan', 'es': 'Sandshrew', 'it': 'Sandshrew', 'en': 'Sandshrew', 'ja': 'サンド', 'zh-Hans': '穿山鼠'}, 'genera': {'ja-Hrkt': 'ねずみポケモン', 'ko': '쥐포켓몬', 'zh-Hant': '鼠寶可夢', 'fr': 'Pokémon Souris', 'de': 'Maus', 'es': 'Pokémon Ratón', 'it': 'Pokémon Topo', 'en': 'Mouse Pokémon', 'ja': 'ねずみポケモン', 'zh-Hans': '鼠宝可梦'}}
	public class SpecieSandshrew : PokemonSpecie
	{
#nullable enable
		private static SpecieSandshrew? _instance = null;
#nullable restore
        public static SpecieSandshrew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSandshrew();
                }
                return _instance;
            }
        }

		public SpecieSandshrew() : base(
			"Sandshrew",
			50, // HPs
			75, 85, // Attack & Defense
			20, 30, // Special Attack & Defense
			40			
		) {}
	}


	//Sandshrew Pokemon Class
	public class Sandshrew : Pokemon
	{

		public Sandshrew(string nickname, int level)
		: base(
				27,
				SpecieSandshrew.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sandshrew() : base(
			27,
			SpecieSandshrew.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}