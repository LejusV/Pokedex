using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Clefable Specie to store common natural stats of every {'abilities': ['cute-charm', 'magic-guard', 'unaware'], 'base_experience': 217, 'height': 13, 'id': 36, 'moves': ['double-slap', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'sing', 'flamethrower', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'minimize', 'defense-curl', 'light-screen', 'reflect', 'bide', 'metronome', 'fire-blast', 'skull-bash', 'soft-boiled', 'dream-eater', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'detect', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'moonlight', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'knock-off', 'endeavor', 'snatch', 'secret-power', 'hyper-voice', 'signal-beam', 'bounce', 'covet', 'calm-mind', 'shock-wave', 'water-pulse', 'gravity', 'natural-gift', 'fling', 'last-resort', 'drain-punch', 'focus-blast', 'giga-impact', 'zen-headbutt', 'captivate', 'stealth-rock', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'after-you', 'round', 'echoed-voice', 'incinerate', 'retaliate', 'work-up', 'disarming-voice', 'confide', 'dazzling-gleam', 'power-up-punch', 'spotlight'], 'name': 'clefable', 'stats': {'hp': 95, 'attack': 70, 'defense': 73, 'special-attack': 95, 'special-defense': 90, 'speed': 60}, 'types': ['fairy'], 'weight': 400, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 6, 'capture_rate': 25, 'color': 'pink', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'fast', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'ピクシー', 'roomaji': 'Pixy', 'ko': '픽시', 'zh-Hant': '皮可西', 'fr': 'Mélodelfe', 'de': 'Pixi', 'es': 'Clefable', 'it': 'Clefable', 'en': 'Clefable', 'ja': 'ピクシー', 'zh-Hans': '皮可西'}, 'genera': {'ja-Hrkt': 'ようせいポケモン', 'ko': '요정포켓몬', 'zh-Hant': '妖精寶可夢', 'fr': 'Pokémon Fée', 'de': 'Fee', 'es': 'Pokémon Hada', 'it': 'Pokémon Fata', 'en': 'Fairy Pokémon', 'ja': 'ようせいポケモン', 'zh-Hans': '妖精宝可梦'}}
	public class SpecieClefable : PokemonSpecie
	{
#nullable enable
		private static SpecieClefable? _instance = null;
#nullable restore
        public static SpecieClefable Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClefable();
                }
                return _instance;
            }
        }

		public SpecieClefable() : base(
			"Clefable",
			95, // HPs
			70, 73, // Attack & Defense
			95, 90, // Special Attack & Defense
			60			
		) {}
	}


	//Clefable Pokemon Class
	public class Clefable : Pokemon
	{

		public Clefable(string nickname, int level)
		: base(
				36,
				SpecieClefable.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Clefable(int level)
		: base(
				36,
				SpecieClefable.Instance, // Pokemon Specie
				"Clefable", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Clefable() : base(
			36,
			SpecieClefable.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}