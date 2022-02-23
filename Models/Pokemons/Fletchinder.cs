using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Fletchinder Specie to store common natural stats of every {'abilities': ['flame-body', 'gale-wings'], 'base_experience': 134, 'height': 7, 'id': 662, 'moves': ['razor-wind', 'swords-dance', 'fly', 'tackle', 'growl', 'ember', 'flamethrower', 'peck', 'toxic', 'agility', 'quick-attack', 'double-team', 'fire-blast', 'rest', 'substitute', 'thief', 'snore', 'flail', 'protect', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'heat-wave', 'will-o-wisp', 'facade', 'taunt', 'snatch', 'secret-power', 'overheat', 'aerial-ace', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'me-first', 'flame-charge', 'round', 'incinerate', 'acrobatics', 'work-up', 'confide'], 'name': 'fletchinder', 'stats': {'hp': 62, 'attack': 73, 'defense': 55, 'special-attack': 56, 'special-defense': 52, 'speed': 84}, 'types': ['fire', 'flying'], 'weight': 160, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'red', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ヒノヤコマ', 'ko': '불화살빈', 'zh-Hant': '火箭雀', 'fr': 'Braisillon', 'de': 'Dartignis', 'es': 'Fletchinder', 'it': 'Fletchinder', 'en': 'Fletchinder', 'ja': 'ヒノヤコマ', 'zh-Hans': '火箭雀'}, 'genera': {'ja-Hrkt': 'ひのこポケモン', 'ko': '불티포켓몬', 'zh-Hant': '火花寶可夢', 'fr': 'Pokémon Braise', 'de': 'Funkenregen', 'es': 'Pokémon Lumbre', 'it': 'Pokémon Sfavillante', 'en': 'Ember Pokémon', 'ja': 'ひのこポケモン', 'zh-Hans': '火花宝可梦'}}
	public class SpecieFletchinder : PokemonSpecie
	{
#nullable enable
		private static SpecieFletchinder? _instance = null;
#nullable restore
        public static SpecieFletchinder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFletchinder();
                }
                return _instance;
            }
        }

		public SpecieFletchinder() : base(
			"Fletchinder",
			62, // HPs
			73, 55, // Attack & Defense
			56, 52, // Special Attack & Defense
			84			
		) {}
	}


	//Fletchinder Pokemon Class
	public class Fletchinder : Pokemon
	{

		public Fletchinder(string nickname, int level) : base(
			662,
			SpecieFletchinder.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance, Flying.Instance			
		) {}

		public Fletchinder() : base(
			662,
			SpecieFletchinder.Instance, // Pokemon Specie
			Fire.Instance, Flying.Instance			
		) {}
	}
}