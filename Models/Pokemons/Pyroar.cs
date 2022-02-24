using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pyroar Specie to store common natural stats of every {'abilities': ['rivalry', 'unnerve', 'moxie'], 'base_experience': 177, 'height': 15, 'id': 668, 'moves': ['headbutt', 'tackle', 'take-down', 'leer', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'strength', 'solar-beam', 'dig', 'toxic', 'double-team', 'fire-blast', 'rest', 'substitute', 'thief', 'snore', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'taunt', 'helping-hand', 'endeavor', 'snatch', 'secret-power', 'hyper-voice', 'overheat', 'bounce', 'payback', 'dark-pulse', 'giga-impact', 'fire-fang', 'flame-charge', 'round', 'echoed-voice', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'wild-charge', 'snarl', 'noble-roar', 'confide'], 'name': 'pyroar', 'stats': {'hp': 86, 'attack': 68, 'defense': 72, 'special-attack': 109, 'special-defense': 66, 'speed': 106}, 'types': ['fire', 'normal'], 'weight': 815, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 7, 'capture_rate': 65, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'カエンジシ', 'ko': '화염레오', 'zh-Hant': '火炎獅', 'fr': 'Némélios', 'de': 'Pyroleo', 'es': 'Pyroar', 'it': 'Pyroar', 'en': 'Pyroar', 'ja': 'カエンジシ', 'zh-Hans': '火炎狮'}, 'genera': {'ja-Hrkt': 'おうじゃポケモン', 'ko': '임금포켓몬', 'zh-Hant': '王者寶可夢', 'fr': 'Pokémon Royal', 'de': 'Monarch', 'es': 'Pokémon Regio', 'it': 'Pokémon Reale', 'en': 'Royal Pokémon', 'ja': 'おうじゃポケモン', 'zh-Hans': '王者宝可梦'}}
	public class SpeciePyroar : PokemonSpecie
	{
#nullable enable
		private static SpeciePyroar? _instance = null;
#nullable restore
        public static SpeciePyroar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePyroar();
                }
                return _instance;
            }
        }

		public SpeciePyroar() : base(
			"Pyroar",
			86, // HPs
			68, 72, // Attack & Defense
			109, 66, // Special Attack & Defense
			106			
		) {}
	}


	//Pyroar Pokemon Class
	public class Pyroar : Pokemon
	{

		public Pyroar(string nickname, int level)
		: base(
				668,
				SpeciePyroar.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pyroar() : base(
			668,
			SpeciePyroar.Instance, // Pokemon Specie
			Fire.Instance, Normal.Instance			
		) {}
	}
}