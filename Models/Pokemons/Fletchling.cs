using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Fletchling Specie to store common natural stats of every {'abilities': ['big-pecks', 'gale-wings'], 'base_experience': 56, 'height': 3, 'id': 661, 'moves': ['razor-wind', 'swords-dance', 'fly', 'tackle', 'growl', 'peck', 'toxic', 'agility', 'quick-attack', 'double-team', 'rest', 'substitute', 'thief', 'snore', 'flail', 'protect', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'heat-wave', 'facade', 'taunt', 'snatch', 'secret-power', 'overheat', 'aerial-ace', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'me-first', 'flame-charge', 'round', 'quick-guard', 'acrobatics', 'work-up', 'confide'], 'name': 'fletchling', 'stats': {'hp': 45, 'attack': 50, 'defense': 43, 'special-attack': 40, 'special-defense': 38, 'speed': 62}, 'types': ['normal', 'flying'], 'weight': 17, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'red', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ヤヤコマ', 'ko': '화살꼬빈', 'zh-Hant': '小箭雀', 'fr': 'Passerouge', 'de': 'Dartiri', 'es': 'Fletchling', 'it': 'Fletchling', 'en': 'Fletchling', 'ja': 'ヤヤコマ', 'zh-Hans': '小箭雀'}, 'genera': {'ja-Hrkt': 'コマドリポケモン', 'ko': '울새포켓몬', 'zh-Hant': '知更鳥寶可夢', 'fr': 'Pokémon Rougegorge', 'de': 'Rotkehlchen', 'es': 'Pokémon Petirrojo', 'it': 'Pokémon Pettirosso', 'en': 'Tiny Robin Pokémon', 'ja': 'コマドリポケモン', 'zh-Hans': '知更鸟宝可梦'}}
	public class SpecieFletchling : PokemonSpecie
	{
#nullable enable
		private static SpecieFletchling? _instance = null;
#nullable restore
        public static SpecieFletchling Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFletchling();
                }
                return _instance;
            }
        }

		public SpecieFletchling() : base(
			"Fletchling",
			45, // HPs
			50, 43, // Attack & Defense
			40, 38, // Special Attack & Defense
			62			
		) {}
	}


	//Fletchling Pokemon Class
	public class Fletchling : Pokemon
	{

		public Fletchling(string nickname, int level) : base(
			661,
			SpecieFletchling.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Flying.Instance			
		) {}

		public Fletchling() : base(
			661,
			SpecieFletchling.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}