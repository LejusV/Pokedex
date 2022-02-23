using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Phione Specie to store common natural stats of every {'abilities': ['hydration'], 'base_experience': 216, 'height': 4, 'id': 489, 'moves': ['supersonic', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'toxic', 'double-team', 'waterfall', 'swift', 'bubble', 'acid-armor', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'charm', 'swagger', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'psych-up', 'ancient-power', 'whirlpool', 'uproar', 'hail', 'facade', 'helping-hand', 'knock-off', 'secret-power', 'dive', 'signal-beam', 'bounce', 'covet', 'water-sport', 'water-pulse', 'brine', 'natural-gift', 'u-turn', 'fling', 'last-resort', 'aqua-ring', 'grass-knot', 'round', 'scald', 'confide', 'dazzling-gleam'], 'name': 'phione', 'stats': {'hp': 80, 'attack': 80, 'defense': 80, 'special-attack': 80, 'special-defense': 80, 'speed': 80}, 'types': ['water'], 'weight': 31, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 40, 'gender_rate': -1, 'capture_rate': 30, 'color': 'blue', 'shape': 'arms', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['water1', 'fairy'], 'names': {'ja-Hrkt': 'フィオネ', 'roomaji': 'Phione', 'ko': '피오네', 'zh-Hant': '霏歐納', 'fr': 'Phione', 'de': 'Phione', 'es': 'Phione', 'it': 'Phione', 'en': 'Phione', 'ja': 'フィオネ', 'zh-Hans': '霏欧纳'}, 'genera': {'ja-Hrkt': 'かいようポケモン', 'ko': '해양포켓몬', 'zh-Hant': '海洋寶可夢', 'fr': 'Pokémon Dérivenmer', 'de': 'Seedrift', 'es': 'Pokémon Marino', 'it': 'Pokémon Oceanbondo', 'en': 'Sea Drifter Pokémon', 'ja': 'かいようポケモン', 'zh-Hans': '海洋宝可梦'}}
	public class SpeciePhione : PokemonSpecie
	{
#nullable enable
		private static SpeciePhione? _instance = null;
#nullable restore
        public static SpeciePhione Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePhione();
                }
                return _instance;
            }
        }

		public SpeciePhione() : base(
			"Phione",
			80, // HPs
			80, 80, // Attack & Defense
			80, 80, // Special Attack & Defense
			80			
		) {}
	}


	//Phione Pokemon Class
	public class Phione : Pokemon
	{

		public Phione(string nickname, int level) : base(
			489,
			SpeciePhione.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Phione() : base(
			489,
			SpeciePhione.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}