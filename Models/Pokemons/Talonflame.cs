using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Talonflame Specie to store common natural stats of every {'abilities': ['flame-body', 'gale-wings'], 'base_experience': 175, 'height': 12, 'id': 663, 'moves': ['razor-wind', 'swords-dance', 'fly', 'tackle', 'growl', 'ember', 'flamethrower', 'hyper-beam', 'peck', 'solar-beam', 'toxic', 'agility', 'quick-attack', 'double-team', 'fire-blast', 'rest', 'substitute', 'thief', 'snore', 'flail', 'protect', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'heat-wave', 'will-o-wisp', 'facade', 'taunt', 'snatch', 'secret-power', 'overheat', 'aerial-ace', 'bulk-up', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'me-first', 'flare-blitz', 'brave-bird', 'giga-impact', 'hone-claws', 'flame-charge', 'round', 'incinerate', 'acrobatics', 'work-up', 'confide'], 'name': 'talonflame', 'stats': {'hp': 78, 'attack': 81, 'defense': 71, 'special-attack': 74, 'special-defense': 69, 'speed': 126}, 'types': ['fire', 'flying'], 'weight': 245, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'red', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ファイアロー', 'ko': '파이어로', 'zh-Hant': '烈箭鷹', 'fr': 'Flambusard', 'de': 'Fiaro', 'es': 'Talonflame', 'it': 'Talonflame', 'en': 'Talonflame', 'ja': 'ファイアロー', 'zh-Hans': '烈箭鹰'}, 'genera': {'ja-Hrkt': 'れっかポケモン', 'ko': '열화포켓몬', 'zh-Hant': '烈火寶可夢', 'fr': 'Pokémon Fournaise', 'de': 'Stichflamme', 'es': 'Pokémon Flamígero', 'it': 'Pokémon Ardifiamma', 'en': 'Scorching Pokémon', 'ja': 'れっかポケモン', 'zh-Hans': '烈火宝可梦'}}
	public class SpecieTalonflame : PokemonSpecie
	{
#nullable enable
		private static SpecieTalonflame? _instance = null;
#nullable restore
        public static SpecieTalonflame Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTalonflame();
                }
                return _instance;
            }
        }

		public SpecieTalonflame() : base(
			"Talonflame",
			78, // HPs
			81, 71, // Attack & Defense
			74, 69, // Special Attack & Defense
			126			
		) {}
	}


	//Talonflame Pokemon Class
	public class Talonflame : Pokemon
	{

		public Talonflame(string nickname, int level)
		: base(
				663,
				SpecieTalonflame.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Talonflame() : base(
			663,
			SpecieTalonflame.Instance, // Pokemon Specie
			Fire.Instance, Flying.Instance			
		) {}
	}
}