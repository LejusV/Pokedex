using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cryogonal Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 180, 'height': 11, 'id': 615, 'moves': ['bind', 'mist', 'ice-beam', 'blizzard', 'aurora-beam', 'hyper-beam', 'solar-beam', 'toxic', 'double-team', 'recover', 'confuse-ray', 'light-screen', 'haze', 'reflect', 'acid-armor', 'explosion', 'rest', 'sharpen', 'slash', 'substitute', 'snore', 'protect', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'rapid-spin', 'hidden-power', 'rain-dance', 'ancient-power', 'hail', 'facade', 'magic-coat', 'knock-off', 'secret-power', 'signal-beam', 'sheer-cold', 'iron-defense', 'water-pulse', 'poison-jab', 'night-slash', 'ice-shard', 'flash-cannon', 'round', 'acrobatics', 'frost-breath', 'freeze-dry', 'confide', 'aurora-veil'], 'name': 'cryogonal', 'stats': {'hp': 80, 'attack': 50, 'defense': 50, 'special-attack': 95, 'special-defense': 135, 'speed': 105}, 'types': ['ice'], 'weight': 1480, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': -1, 'capture_rate': 25, 'color': 'blue', 'shape': 'ball', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'フリージオ', 'ko': '프리지오', 'zh-Hant': '幾何雪花', 'fr': 'Hexagel', 'de': 'Frigometri', 'es': 'Cryogonal', 'it': 'Cryogonal', 'en': 'Cryogonal', 'ja': 'フリージオ', 'zh-Hans': '几何雪花'}, 'genera': {'ja-Hrkt': 'けっしょうポケモン', 'ko': '결정포켓몬', 'zh-Hant': '結晶寶可夢', 'fr': 'Pokémon Cristal', 'de': 'Kristall', 'es': 'Pokémon Cristal', 'it': 'Pokémon Cristallo', 'en': 'Crystallizing Pokémon', 'ja': 'けっしょうポケモン', 'zh-Hans': '结晶宝可梦'}}
	public class SpecieCryogonal : PokemonSpecie
	{
#nullable enable
		private static SpecieCryogonal? _instance = null;
#nullable restore
        public static SpecieCryogonal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCryogonal();
                }
                return _instance;
            }
        }

		public SpecieCryogonal() : base(
			"Cryogonal",
			80, // HPs
			50, 50, // Attack & Defense
			95, 135, // Special Attack & Defense
			105			
		) {}
	}


	//Cryogonal Pokemon Class
	public class Cryogonal : Pokemon
	{

		public Cryogonal(string nickname, int level)
		: base(
				615,
				SpecieCryogonal.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cryogonal() : base(
			615,
			SpecieCryogonal.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}