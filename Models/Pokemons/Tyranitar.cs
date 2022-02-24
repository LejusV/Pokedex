using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tyranitar Specie to store common natural stats of every {'abilities': ['sand-stream', 'unnerve'], 'base_experience': 270, 'height': 20, 'id': 248, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'thrash', 'double-edge', 'leer', 'bite', 'roar', 'flamethrower', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'dig', 'toxic', 'mimic', 'screech', 'double-team', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'scary-face', 'mud-slap', 'detect', 'outrage', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'dragon-breath', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'torment', 'facade', 'focus-punch', 'taunt', 'superpower', 'brick-break', 'secret-power', 'rock-tomb', 'aerial-ace', 'iron-defense', 'block', 'dragon-claw', 'shock-wave', 'water-pulse', 'natural-gift', 'payback', 'fling', 'rock-polish', 'dark-pulse', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'avalanche', 'shadow-claw', 'thunder-fang', 'ice-fang', 'fire-fang', 'rock-climb', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'hone-claws', 'smack-down', 'foul-play', 'round', 'chip-away', 'incinerate', 'retaliate', 'bulldoze', 'dragon-tail', 'snarl', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'tyranitar', 'stats': {'hp': 100, 'attack': 134, 'defense': 110, 'special-attack': 95, 'special-defense': 100, 'speed': 61}, 'types': ['rock', 'dark'], 'weight': 2020, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'バンギラス', 'roomaji': 'Bangiras', 'ko': '마기라스', 'zh-Hant': '班基拉斯', 'fr': 'Tyranocif', 'de': 'Despotar', 'es': 'Tyranitar', 'it': 'Tyranitar', 'en': 'Tyranitar', 'ja': 'バンギラス', 'zh-Hans': '班基拉斯'}, 'genera': {'ja-Hrkt': 'よろいポケモン', 'ko': '갑옷포켓몬', 'zh-Hant': '鎧甲寶可夢', 'fr': 'Pokémon Armure', 'de': 'Panzer', 'es': 'Pokémon Coraza', 'it': 'Pokémon Armatura', 'en': 'Armor Pokémon', 'ja': 'よろいポケモン', 'zh-Hans': '铠甲宝可梦'}}
	public class SpecieTyranitar : PokemonSpecie
	{
#nullable enable
		private static SpecieTyranitar? _instance = null;
#nullable restore
        public static SpecieTyranitar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTyranitar();
                }
                return _instance;
            }
        }

		public SpecieTyranitar() : base(
			"Tyranitar",
			100, // HPs
			134, 110, // Attack & Defense
			95, 100, // Special Attack & Defense
			61			
		) {}
	}


	//Tyranitar Pokemon Class
	public class Tyranitar : Pokemon
	{

		public Tyranitar(string nickname, int level)
		: base(
				248,
				SpecieTyranitar.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tyranitar(int level)
		: base(
				248,
				SpecieTyranitar.Instance, // Pokemon Specie
				"Tyranitar", level,
				Rock.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tyranitar() : base(
			248,
			SpecieTyranitar.Instance, // Pokemon Specie
			Rock.Instance, Dark.Instance			
		) {}
	}
}