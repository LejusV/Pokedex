using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Regirock Specie to store common natural stats of every {'abilities': ['clear-body', 'sturdy'], 'base_experience': 261, 'height': 17, 'id': 377, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'stomp', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'rock-throw', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'self-destruct', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'lock-on', 'sandstorm', 'endure', 'rollout', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'hidden-power', 'sunny-day', 'psych-up', 'ancient-power', 'rock-smash', 'facade', 'focus-punch', 'superpower', 'brick-break', 'secret-power', 'rock-tomb', 'iron-defense', 'block', 'shock-wave', 'gravity', 'hammer-arm', 'natural-gift', 'fling', 'rock-polish', 'drain-punch', 'focus-blast', 'earth-power', 'giga-impact', 'rock-climb', 'iron-head', 'stone-edge', 'stealth-rock', 'charge-beam', 'smack-down', 'round', 'bulldoze', 'confide', 'power-up-punch'], 'name': 'regirock', 'stats': {'hp': 80, 'attack': 100, 'defense': 200, 'special-attack': 50, 'special-defense': 100, 'speed': 50}, 'types': ['rock'], 'weight': 2300, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'brown', 'shape': 'humanoid', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'レジロック', 'roomaji': 'Regirock', 'ko': '레지락', 'zh-Hant': '雷吉洛克', 'fr': 'Regirock', 'de': 'Regirock', 'es': 'Regirock', 'it': 'Regirock', 'en': 'Regirock', 'ja': 'レジロック', 'zh-Hans': '雷吉洛克'}, 'genera': {'ja-Hrkt': 'いわやまポケモン', 'ko': '바위산포켓몬', 'zh-Hant': '岩山寶可夢', 'fr': 'Pokémon Pic Rocheux', 'de': 'Steingipfel', 'es': 'Pokémon Pico Roca', 'it': 'Pokémon Picco', 'en': 'Rock Peak Pokémon', 'ja': 'いわやまポケモン', 'zh-Hans': '岩山宝可梦'}}
	public class SpecieRegirock : PokemonSpecie
	{
#nullable enable
		private static SpecieRegirock? _instance = null;
#nullable restore
        public static SpecieRegirock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRegirock();
                }
                return _instance;
            }
        }

		public SpecieRegirock() : base(
			"Regirock",
			80, // HPs
			100, 200, // Attack & Defense
			50, 100, // Special Attack & Defense
			50			
		) {}
	}


	//Regirock Pokemon Class
	public class Regirock : Pokemon
	{

		public Regirock(string nickname, int level)
		: base(
				377,
				SpecieRegirock.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Regirock(int level)
		: base(
				377,
				SpecieRegirock.Instance, // Pokemon Specie
				"Regirock", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Regirock() : base(
			377,
			SpecieRegirock.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}