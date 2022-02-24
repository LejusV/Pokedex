using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mewtwo Specie to store common natural stats of every {'abilities': ['pressure', 'unnerve'], 'base_experience': 306, 'height': 20, 'id': 150, 'moves': ['mega-punch', 'pay-day', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'disable', 'flamethrower', 'mist', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'confusion', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'recover', 'barrier', 'light-screen', 'reflect', 'bide', 'metronome', 'self-destruct', 'fire-blast', 'swift', 'skull-bash', 'amnesia', 'dream-eater', 'flash', 'psywave', 'rest', 'rock-slide', 'tri-attack', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'detect', 'sandstorm', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'rock-smash', 'hail', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'skill-swap', 'snatch', 'secret-power', 'dive', 'rock-tomb', 'signal-beam', 'aerial-ace', 'bulk-up', 'calm-mind', 'shock-wave', 'water-pulse', 'gravity', 'miracle-eye', 'natural-gift', 'embargo', 'fling', 'me-first', 'power-swap', 'guard-swap', 'aura-sphere', 'poison-jab', 'aqua-tail', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'avalanche', 'psycho-cut', 'zen-headbutt', 'rock-climb', 'trick-room', 'stone-edge', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'low-sweep', 'foul-play', 'round', 'incinerate', 'bulldoze', 'psystrike', 'confide', 'power-up-punch', 'laser-focus', 'brutal-swing'], 'name': 'mewtwo', 'stats': {'hp': 106, 'attack': 110, 'defense': 90, 'special-attack': 154, 'special-defense': 90, 'speed': 130}, 'types': ['psychic'], 'weight': 1220, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'purple', 'shape': 'upright', 'habitat': 'rare', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ミュウツー', 'roomaji': 'Mewtwo', 'ko': '뮤츠', 'zh-Hant': '超夢', 'fr': 'Mewtwo', 'de': 'Mewtu', 'es': 'Mewtwo', 'it': 'Mewtwo', 'en': 'Mewtwo', 'ja': 'ミュウツー', 'zh-Hans': '超梦'}, 'genera': {'ja-Hrkt': 'いでんしポケモン', 'ko': '유전포켓몬', 'zh-Hant': '基因寶可夢', 'fr': 'Pokémon Génétique', 'de': 'Genmutant', 'es': 'Pokémon Genético', 'it': 'Pokémon Genetico', 'en': 'Genetic Pokémon', 'ja': 'いでんしポケモン', 'zh-Hans': '基因宝可梦'}}
	public class SpecieMewtwo : PokemonSpecie
	{
#nullable enable
		private static SpecieMewtwo? _instance = null;
#nullable restore
        public static SpecieMewtwo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMewtwo();
                }
                return _instance;
            }
        }

		public SpecieMewtwo() : base(
			"Mewtwo",
			106, // HPs
			110, 90, // Attack & Defense
			154, 90, // Special Attack & Defense
			130			
		) {}
	}


	//Mewtwo Pokemon Class
	public class Mewtwo : Pokemon
	{

		public Mewtwo(string nickname, int level)
		: base(
				150,
				SpecieMewtwo.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mewtwo(int level)
		: base(
				150,
				SpecieMewtwo.Instance, // Pokemon Specie
				"Mewtwo", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mewtwo() : base(
			150,
			SpecieMewtwo.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}