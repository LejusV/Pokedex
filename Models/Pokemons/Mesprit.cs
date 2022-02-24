using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mesprit Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 261, 'height': 3, 'id': 481, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'headbutt', 'ice-beam', 'blizzard', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'sandstorm', 'endure', 'charm', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'facade', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'knock-off', 'skill-swap', 'imprison', 'secret-power', 'signal-beam', 'extrasensory', 'calm-mind', 'shock-wave', 'water-pulse', 'healing-wish', 'natural-gift', 'u-turn', 'fling', 'lucky-chant', 'copycat', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'stealth-rock', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'round', 'acrobatics', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'mesprit', 'stats': {'hp': 80, 'attack': 105, 'defense': 105, 'special-attack': 105, 'special-defense': 105, 'speed': 80}, 'types': ['psychic'], 'weight': 3, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'pink', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'エムリット', 'roomaji': 'Emrit', 'ko': '엠라이트', 'zh-Hant': '艾姆利多', 'fr': 'Créfollet', 'de': 'Vesprit', 'es': 'Mesprit', 'it': 'Mesprit', 'en': 'Mesprit', 'ja': 'エムリット', 'zh-Hans': '艾姆利多'}, 'genera': {'ja-Hrkt': 'かんじょうポケモン', 'ko': '감정포켓몬', 'zh-Hant': '感情寶可夢', 'fr': 'Pokémon Émotion', 'de': 'Emotion', 'es': 'Pokémon Sensorio', 'it': 'Pokémon Emozione', 'en': 'Emotion Pokémon', 'ja': 'かんじょうポケモン', 'zh-Hans': '感情宝可梦'}}
	public class SpecieMesprit : PokemonSpecie
	{
#nullable enable
		private static SpecieMesprit? _instance = null;
#nullable restore
        public static SpecieMesprit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMesprit();
                }
                return _instance;
            }
        }

		public SpecieMesprit() : base(
			"Mesprit",
			80, // HPs
			105, 105, // Attack & Defense
			105, 105, // Special Attack & Defense
			80			
		) {}
	}


	//Mesprit Pokemon Class
	public class Mesprit : Pokemon
	{

		public Mesprit(string nickname, int level)
		: base(
				481,
				SpecieMesprit.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mesprit() : base(
			481,
			SpecieMesprit.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}