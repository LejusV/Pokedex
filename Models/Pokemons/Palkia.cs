using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Palkia Specie to store common natural stats of every {'abilities': ['pressure', 'telepathy'], 'base_experience': 306, 'height': 42, 'id': 484, 'moves': ['cut', 'headbutt', 'roar', 'flamethrower', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'double-team', 'fire-blast', 'swift', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'scary-face', 'mud-slap', 'outrage', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'brick-break', 'secret-power', 'dive', 'hyper-voice', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'bulk-up', 'shock-wave', 'water-pulse', 'gravity', 'brine', 'natural-gift', 'fling', 'heal-block', 'aqua-ring', 'aura-sphere', 'aqua-tail', 'dragon-pulse', 'power-gem', 'focus-blast', 'earth-power', 'giga-impact', 'avalanche', 'shadow-claw', 'trick-room', 'draco-meteor', 'stone-edge', 'spacial-rend', 'hone-claws', 'round', 'echoed-voice', 'incinerate', 'bulldoze', 'dragon-tail', 'confide'], 'name': 'palkia', 'stats': {'hp': 90, 'attack': 120, 'defense': 100, 'special-attack': 150, 'special-defense': 120, 'speed': 100}, 'types': ['water', 'dragon'], 'weight': 3360, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'purple', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'パルキア', 'roomaji': 'Palkia', 'ko': '펄기아', 'zh-Hant': '帕路奇亞', 'fr': 'Palkia', 'de': 'Palkia', 'es': 'Palkia', 'it': 'Palkia', 'en': 'Palkia', 'ja': 'パルキア', 'zh-Hans': '帕路奇亚'}, 'genera': {'ja-Hrkt': 'くうかんポケモン', 'ko': '공간포켓몬', 'zh-Hant': '空間寶可夢', 'fr': 'Pokémon Espace', 'de': 'Räumlich', 'es': 'Pokémon Espacial', 'it': 'Pokémon Spazio', 'en': 'Spatial Pokémon', 'ja': 'くうかんポケモン', 'zh-Hans': '空间宝可梦'}}
	public class SpeciePalkia : PokemonSpecie
	{
#nullable enable
		private static SpeciePalkia? _instance = null;
#nullable restore
        public static SpeciePalkia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePalkia();
                }
                return _instance;
            }
        }

		public SpeciePalkia() : base(
			"Palkia",
			90, // HPs
			120, 100, // Attack & Defense
			150, 120, // Special Attack & Defense
			100			
		) {}
	}


	//Palkia Pokemon Class
	public class Palkia : Pokemon
	{

		public Palkia(string nickname, int level)
		: base(
				484,
				SpeciePalkia.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Palkia(int level)
		: base(
				484,
				SpeciePalkia.Instance, // Pokemon Specie
				"Palkia", level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Palkia() : base(
			484,
			SpeciePalkia.Instance, // Pokemon Specie
			Water.Instance, Dragon.Instance			
		) {}
	}
}