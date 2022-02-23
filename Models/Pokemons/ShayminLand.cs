using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shaymin-Land Specie to store common natural stats of every {'abilities': ['natural-cure'], 'base_experience': 270, 'height': 2, 'id': 492, 'moves': ['swords-dance', 'headbutt', 'hyper-beam', 'leech-seed', 'growth', 'solar-beam', 'toxic', 'psychic', 'double-team', 'defense-curl', 'swift', 'flash', 'rest', 'substitute', 'snore', 'protect', 'sweet-kiss', 'mud-slap', 'giga-drain', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'psych-up', 'facade', 'nature-power', 'endeavor', 'secret-power', 'aromatherapy', 'grass-whistle', 'bullet-seed', 'covet', 'magical-leaf', 'healing-wish', 'natural-gift', 'lucky-chant', 'last-resort', 'worry-seed', 'seed-bomb', 'energy-ball', 'earth-power', 'giga-impact', 'zen-headbutt', 'grass-knot', 'seed-flare', 'round', 'confide', 'dazzling-gleam'], 'name': 'shaymin-land', 'stats': {'hp': 100, 'attack': 100, 'defense': 100, 'special-attack': 100, 'special-defense': 100, 'speed': 100}, 'types': ['grass'], 'weight': 21, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'green', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'シェイミ', 'roomaji': 'Shaymin', 'ko': '쉐이미', 'zh-Hant': '謝米', 'fr': 'Shaymin', 'de': 'Shaymin', 'es': 'Shaymin', 'it': 'Shaymin', 'en': 'Shaymin', 'ja': 'シェイミ', 'zh-Hans': '谢米'}, 'genera': {'ja-Hrkt': 'かんしゃポケモン', 'ko': '감사포켓몬', 'zh-Hant': '感謝寶可夢', 'fr': 'Pokémon Gratitude', 'de': 'Dankbarkeit', 'es': 'Pokémon Gratitud', 'it': 'Pokémon Gratitudine', 'en': 'Gratitude Pokémon', 'ja': 'かんしゃポケモン', 'zh-Hans': '感谢宝可梦'}}
	public class SpecieShayminLand : PokemonSpecie
	{
#nullable enable
		private static SpecieShayminLand? _instance = null;
#nullable restore
        public static SpecieShayminLand Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShayminLand();
                }
                return _instance;
            }
        }

		public SpecieShayminLand() : base(
			"Shaymin-Land",
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100			
		) {}
	}


	//Shaymin-Land Pokemon Class
	public class ShayminLand : Pokemon
	{

		public ShayminLand(string nickname, int level) : base(
			492,
			SpecieShayminLand.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public ShayminLand() : base(
			492,
			SpecieShayminLand.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}