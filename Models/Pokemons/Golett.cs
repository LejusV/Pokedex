using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Golett Specie to store common natural stats of every {'abilities': ['iron-fist', 'klutz', 'no-guard'], 'base_experience': 61, 'height': 10, 'id': 622, 'moves': ['pound', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'ice-beam', 'low-kick', 'strength', 'earthquake', 'toxic', 'psychic', 'night-shade', 'double-team', 'defense-curl', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'rollout', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'magnitude', 'dynamic-punch', 'hidden-power', 'rain-dance', 'shadow-ball', 'rock-smash', 'facade', 'focus-punch', 'superpower', 'magic-coat', 'brick-break', 'secret-power', 'astonish', 'rock-tomb', 'signal-beam', 'shadow-punch', 'iron-defense', 'block', 'shock-wave', 'gravity', 'hammer-arm', 'gyro-ball', 'fling', 'rock-polish', 'drain-punch', 'focus-blast', 'earth-power', 'stealth-rock', 'grass-knot', 'telekinesis', 'low-sweep', 'round', 'bulldoze', 'confide', 'power-up-punch', 'stomping-tantrum'], 'name': 'golett', 'stats': {'hp': 59, 'attack': 74, 'defense': 50, 'special-attack': 35, 'special-defense': 50, 'speed': 35}, 'types': ['ground', 'ghost'], 'weight': 920, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': -1, 'capture_rate': 190, 'color': 'green', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ゴビット', 'ko': '골비람', 'zh-Hant': '泥偶小人', 'fr': 'Gringolem', 'de': 'Golbit', 'es': 'Golett', 'it': 'Golett', 'en': 'Golett', 'ja': 'ゴビット', 'zh-Hans': '泥偶小人'}, 'genera': {'ja-Hrkt': 'ゴーレムポケモン', 'ko': '골렘포켓몬', 'zh-Hant': '魔像寶可夢', 'fr': 'Pokémon Golem Ancien', 'de': 'Urgolem', 'es': 'Pokémon Autómata', 'it': 'Pokémon Statuanimata', 'en': 'Automaton Pokémon', 'ja': 'ゴーレムポケモン', 'zh-Hans': '魔像宝可梦'}}
	public class SpecieGolett : PokemonSpecie
	{
#nullable enable
		private static SpecieGolett? _instance = null;
#nullable restore
        public static SpecieGolett Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGolett();
                }
                return _instance;
            }
        }

		public SpecieGolett() : base(
			"Golett",
			59, // HPs
			74, 50, // Attack & Defense
			35, 50, // Special Attack & Defense
			35			
		) {}
	}


	//Golett Pokemon Class
	public class Golett : Pokemon
	{

		public Golett(string nickname, int level) : base(
			622,
			SpecieGolett.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance, Ghost.Instance			
		) {}

		public Golett() : base(
			622,
			SpecieGolett.Instance, // Pokemon Specie
			Ground.Instance, Ghost.Instance			
		) {}
	}
}