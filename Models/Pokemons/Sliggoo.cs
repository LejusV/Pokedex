using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sliggoo Specie to store common natural stats of every {'abilities': ['sap-sipper', 'hydration', 'gooey'], 'base_experience': 158, 'height': 8, 'id': 705, 'moves': ['tackle', 'body-slam', 'ice-beam', 'blizzard', 'absorb', 'thunderbolt', 'toxic', 'double-team', 'bide', 'bubble', 'rest', 'rock-slide', 'substitute', 'snore', 'flail', 'protect', 'sludge-bomb', 'outrage', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'facade', 'secret-power', 'muddy-water', 'shock-wave', 'water-pulse', 'dragon-pulse', 'draco-meteor', 'sludge-wave', 'round', 'confide', 'infestation'], 'name': 'sliggoo', 'stats': {'hp': 68, 'attack': 75, 'defense': 53, 'special-attack': 83, 'special-defense': 113, 'speed': 60}, 'types': ['dragon'], 'weight': 175, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'slow', 'egg_groups': ['dragon'], 'names': {'ja-Hrkt': 'ヌメイル', 'ko': '미끄네일', 'zh-Hant': '黏美兒', 'fr': 'Colimucus', 'de': 'Viscargot', 'es': 'Sliggoo', 'it': 'Sliggoo', 'en': 'Sliggoo', 'ja': 'ヌメイル', 'zh-Hans': '黏美儿'}, 'genera': {'ja-Hrkt': 'なんたいポケモン', 'ko': '연체포켓몬', 'zh-Hant': '軟體生物寶可夢', 'fr': 'Pokémon Mollusque', 'de': 'Schneckedei', 'es': 'Pokémon Molusco', 'it': 'Pokémon Mollusco', 'en': 'Soft Tissue Pokémon', 'ja': 'なんたいポケモン', 'zh-Hans': '软体生物宝可梦'}}
	public class SpecieSliggoo : PokemonSpecie
	{
#nullable enable
		private static SpecieSliggoo? _instance = null;
#nullable restore
        public static SpecieSliggoo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSliggoo();
                }
                return _instance;
            }
        }

		public SpecieSliggoo() : base(
			"Sliggoo",
			68, // HPs
			75, 53, // Attack & Defense
			83, 113, // Special Attack & Defense
			60			
		) {}
	}


	//Sliggoo Pokemon Class
	public class Sliggoo : Pokemon
	{

		public Sliggoo(string nickname, int level) : base(
			705,
			SpecieSliggoo.Instance, // Pokemon Specie
			nickname, level,
			Dragon.Instance			
		) {}

		public Sliggoo() : base(
			705,
			SpecieSliggoo.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}