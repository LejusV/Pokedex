using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Golurk Specie to store common natural stats of every {'abilities': ['iron-fist', 'klutz', 'no-guard'], 'base_experience': 169, 'height': 28, 'id': 623, 'moves': ['pound', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'fly', 'ice-beam', 'hyper-beam', 'low-kick', 'strength', 'solar-beam', 'thunderbolt', 'earthquake', 'toxic', 'psychic', 'night-shade', 'double-team', 'defense-curl', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'rollout', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'magnitude', 'dynamic-punch', 'hidden-power', 'rain-dance', 'shadow-ball', 'rock-smash', 'facade', 'focus-punch', 'superpower', 'magic-coat', 'brick-break', 'secret-power', 'astonish', 'rock-tomb', 'signal-beam', 'shadow-punch', 'iron-defense', 'block', 'shock-wave', 'gravity', 'hammer-arm', 'gyro-ball', 'fling', 'rock-polish', 'drain-punch', 'focus-blast', 'earth-power', 'giga-impact', 'zen-headbutt', 'flash-cannon', 'stone-edge', 'stealth-rock', 'grass-knot', 'charge-beam', 'telekinesis', 'heavy-slam', 'low-sweep', 'round', 'bulldoze', 'phantom-force', 'confide', 'power-up-punch', 'high-horsepower', 'stomping-tantrum'], 'name': 'golurk', 'stats': {'hp': 89, 'attack': 124, 'defense': 80, 'special-attack': 55, 'special-defense': 80, 'speed': 55}, 'types': ['ground', 'ghost'], 'weight': 3300, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': -1, 'capture_rate': 90, 'color': 'green', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ゴルーグ', 'ko': '골루그', 'zh-Hant': '泥偶巨人', 'fr': 'Golemastoc', 'de': 'Golgantes', 'es': 'Golurk', 'it': 'Golurk', 'en': 'Golurk', 'ja': 'ゴルーグ', 'zh-Hans': '泥偶巨人'}, 'genera': {'ja-Hrkt': 'ゴーレムポケモン', 'ko': '골렘포켓몬', 'zh-Hant': '魔像寶可夢', 'fr': 'Pokémon Golem Ancien', 'de': 'Urgolem', 'es': 'Pokémon Autómata', 'it': 'Pokémon Statuanimata', 'en': 'Automaton Pokémon', 'ja': 'ゴーレムポケモン', 'zh-Hans': '魔像宝可梦'}}
	public class SpecieGolurk : PokemonSpecie
	{
#nullable enable
		private static SpecieGolurk? _instance = null;
#nullable restore
        public static SpecieGolurk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGolurk();
                }
                return _instance;
            }
        }

		public SpecieGolurk() : base(
			"Golurk",
			89, // HPs
			124, 80, // Attack & Defense
			55, 80, // Special Attack & Defense
			55			
		) {}
	}


	//Golurk Pokemon Class
	public class Golurk : Pokemon
	{

		public Golurk(string nickname, int level)
		: base(
				623,
				SpecieGolurk.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Golurk() : base(
			623,
			SpecieGolurk.Instance, // Pokemon Specie
			Ground.Instance, Ghost.Instance			
		) {}
	}
}