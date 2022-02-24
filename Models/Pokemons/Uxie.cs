using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Uxie Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 261, 'height': 3, 'id': 480, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'headbutt', 'hyper-beam', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'swift', 'amnesia', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'flail', 'protect', 'mud-slap', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'memento', 'facade', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'yawn', 'knock-off', 'skill-swap', 'imprison', 'secret-power', 'signal-beam', 'extrasensory', 'calm-mind', 'shock-wave', 'water-pulse', 'natural-gift', 'u-turn', 'fling', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'stealth-rock', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'foul-play', 'round', 'acrobatics', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'uxie', 'stats': {'hp': 75, 'attack': 75, 'defense': 130, 'special-attack': 75, 'special-defense': 130, 'speed': 95}, 'types': ['psychic'], 'weight': 3, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'yellow', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ユクシー', 'roomaji': 'Yuxie', 'ko': '유크시', 'zh-Hant': '由克希', 'fr': 'Créhelf', 'de': 'Selfe', 'es': 'Uxie', 'it': 'Uxie', 'en': 'Uxie', 'ja': 'ユクシー', 'zh-Hans': '由克希'}, 'genera': {'ja-Hrkt': 'ちしきポケモン', 'ko': '지식포켓몬', 'zh-Hant': '知識寶可夢', 'fr': 'Pokémon Savoir', 'de': 'Wissen', 'es': 'Pokémon Sabiduría', 'it': 'Pokémon Sapienza', 'en': 'Knowledge Pokémon', 'ja': 'ちしきポケモン', 'zh-Hans': '知识宝可梦'}}
	public class SpecieUxie : PokemonSpecie
	{
#nullable enable
		private static SpecieUxie? _instance = null;
#nullable restore
        public static SpecieUxie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieUxie();
                }
                return _instance;
            }
        }

		public SpecieUxie() : base(
			"Uxie",
			75, // HPs
			75, 130, // Attack & Defense
			75, 130, // Special Attack & Defense
			95			
		) {}
	}


	//Uxie Pokemon Class
	public class Uxie : Pokemon
	{

		public Uxie(string nickname, int level)
		: base(
				480,
				SpecieUxie.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Uxie() : base(
			480,
			SpecieUxie.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}