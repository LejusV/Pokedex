using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Magearna Specie to store common natural stats of every {'abilities': ['soul-heart'], 'base_experience': 270, 'height': 10, 'id': 801, 'moves': ['sonic-boom', 'ice-beam', 'psybeam', 'aurora-beam', 'hyper-beam', 'solar-beam', 'thunderbolt', 'thunder-wave', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'explosion', 'substitute', 'mind-reader', 'protect', 'false-swipe', 'swagger', 'return', 'frustration', 'pain-split', 'hidden-power', 'shadow-ball', 'helping-hand', 'brick-break', 'iron-defense', 'calm-mind', 'gyro-ball', 'embargo', 'trump-card', 'lucky-chant', 'heart-swap', 'aura-sphere', 'focus-blast', 'energy-ball', 'giga-impact', 'mirror-shot', 'flash-cannon', 'trick-room', 'iron-head', 'grass-knot', 'charge-beam', 'synchronoise', 'round', 'echoed-voice', 'shift-gear', 'volt-switch', 'crafty-shield', 'confide', 'dazzling-gleam', 'gear-up', 'fleur-cannon'], 'name': 'magearna', 'stats': {'hp': 80, 'attack': 95, 'defense': 115, 'special-attack': 130, 'special-defense': 115, 'speed': 65}, 'types': ['steel', 'fairy'], 'weight': 805, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'gray', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'マギアナ', 'ko': '마기아나', 'zh-Hant': '瑪機雅娜', 'fr': 'Magearna', 'de': 'Magearna', 'es': 'Magearna', 'it': 'Magearna', 'en': 'Magearna', 'ja': 'マギアナ', 'zh-Hans': '玛机雅娜'}, 'genera': {'ja-Hrkt': 'じんぞうポケモン', 'ko': '인조포켓몬', 'zh-Hant': '人造寶可夢', 'fr': 'Pokémon Artificiel', 'de': 'Fabrikat', 'es': 'Pokémon Artificial', 'it': 'Pokémon Artificiale', 'en': 'Artificial Pokémon', 'ja': 'じんぞうポケモン', 'zh-Hans': '人造宝可梦'}}
	public class SpecieMagearna : PokemonSpecie
	{
#nullable enable
		private static SpecieMagearna? _instance = null;
#nullable restore
        public static SpecieMagearna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagearna();
                }
                return _instance;
            }
        }

		public SpecieMagearna() : base(
			"Magearna",
			80, // HPs
			95, 115, // Attack & Defense
			130, 115, // Special Attack & Defense
			65			
		) {}
	}


	//Magearna Pokemon Class
	public class Magearna : Pokemon
	{

		public Magearna(string nickname, int level) : base(
			801,
			SpecieMagearna.Instance, // Pokemon Specie
			nickname, level,
			Steel.Instance, Fairy.Instance			
		) {}

		public Magearna() : base(
			801,
			SpecieMagearna.Instance, // Pokemon Specie
			Steel.Instance, Fairy.Instance			
		) {}
	}
}