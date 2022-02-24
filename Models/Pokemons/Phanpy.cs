using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Phanpy Specie to store common natural stats of every {'abilities': ['pickup', 'sand-veil'], 'base_experience': 66, 'height': 5, 'id': 231, 'moves': ['slam', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'roar', 'water-gun', 'counter', 'strength', 'earthquake', 'fissure', 'toxic', 'mimic', 'double-team', 'defense-curl', 'focus-energy', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'sandstorm', 'endure', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'facade', 'superpower', 'knock-off', 'endeavor', 'secret-power', 'hyper-voice', 'odor-sleuth', 'rock-tomb', 'natural-gift', 'last-resort', 'seed-bomb', 'earth-power', 'ice-shard', 'gunk-shot', 'captivate', 'stealth-rock', 'head-smash', 'heavy-slam', 'round', 'echoed-voice', 'bulldoze', 'play-rough', 'confide', 'high-horsepower'], 'name': 'phanpy', 'stats': {'hp': 90, 'attack': 60, 'defense': 60, 'special-attack': 40, 'special-defense': 40, 'speed': 40}, 'types': ['ground'], 'weight': 335, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'blue', 'shape': 'quadruped', 'habitat': 'rough-terrain', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ゴマゾウ', 'roomaji': 'Gomazou', 'ko': '코코리', 'zh-Hant': '小小象', 'fr': 'Phanpy', 'de': 'Phanpy', 'es': 'Phanpy', 'it': 'Phanpy', 'en': 'Phanpy', 'ja': 'ゴマゾウ', 'zh-Hans': '小小象'}, 'genera': {'ja-Hrkt': 'ながはなポケモン', 'ko': '긴코포켓몬', 'zh-Hant': '長鼻寶可夢', 'fr': 'Pokémon Long-Nez', 'de': 'Langrüssel', 'es': 'Pokémon Narizotas', 'it': 'Pokémon Nasone', 'en': 'Long Nose Pokémon', 'ja': 'ながはなポケモン', 'zh-Hans': '长鼻宝可梦'}}
	public class SpeciePhanpy : PokemonSpecie
	{
#nullable enable
		private static SpeciePhanpy? _instance = null;
#nullable restore
        public static SpeciePhanpy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePhanpy();
                }
                return _instance;
            }
        }

		public SpeciePhanpy() : base(
			"Phanpy",
			90, // HPs
			60, 60, // Attack & Defense
			40, 40, // Special Attack & Defense
			40			
		) {}
	}


	//Phanpy Pokemon Class
	public class Phanpy : Pokemon
	{

		public Phanpy(string nickname, int level)
		: base(
				231,
				SpeciePhanpy.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Phanpy() : base(
			231,
			SpeciePhanpy.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}