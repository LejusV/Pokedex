using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ivysaur Specie to store common natural stats of every {'abilities': ['overgrow', 'chlorophyll'], 'base_experience': 142, 'height': 10, 'id': 2, 'moves': ['swords-dance', 'cut', 'bind', 'vine-whip', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'strength', 'mega-drain', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'poison-powder', 'sleep-powder', 'string-shot', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'bide', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'nature-power', 'knock-off', 'secret-power', 'bullet-seed', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'captivate', 'grass-knot', 'venoshock', 'round', 'echoed-voice', 'grass-pledge', 'work-up', 'confide'], 'name': 'ivysaur', 'stats': {'hp': 60, 'attack': 62, 'defense': 63, 'special-attack': 80, 'special-defense': 80, 'speed': 60}, 'types': ['grass', 'poison'], 'weight': 130, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'plant'], 'names': {'ja-Hrkt': 'フシギソウ', 'roomaji': 'Fushigisou', 'ko': '이상해풀', 'zh-Hant': '妙蛙草', 'fr': 'Herbizarre', 'de': 'Bisaknosp', 'es': 'Ivysaur', 'it': 'Ivysaur', 'en': 'Ivysaur', 'ja': 'フシギソウ', 'zh-Hans': '妙蛙草'}, 'genera': {'ja-Hrkt': 'たねポケモン', 'ko': '씨앗포켓몬', 'zh-Hant': '種子寶可夢', 'fr': 'Pokémon Graine', 'de': 'Samen', 'es': 'Pokémon Semilla', 'it': 'Pokémon Seme', 'en': 'Seed Pokémon', 'ja': 'たねポケモン', 'zh-Hans': '种子宝可梦'}}
	public class SpecieIvysaur : PokemonSpecie
	{
#nullable enable
		private static SpecieIvysaur? _instance = null;
#nullable restore
        public static SpecieIvysaur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieIvysaur();
                }
                return _instance;
            }
        }

		public SpecieIvysaur() : base(
			"Ivysaur",
			60, // HPs
			62, 63, // Attack & Defense
			80, 80, // Special Attack & Defense
			60			
		) {}
	}


	//Ivysaur Pokemon Class
	public class Ivysaur : Pokemon
	{

		public Ivysaur(string nickname, int level) : base(
			2,
			SpecieIvysaur.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Poison.Instance			
		) {}

		public Ivysaur() : base(
			2,
			SpecieIvysaur.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}