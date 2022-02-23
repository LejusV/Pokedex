using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Registeel Specie to store common natural stats of every {'abilities': ['clear-body', 'light-metal'], 'base_experience': 261, 'height': 19, 'id': 379, 'moves': ['mega-punch', 'ice-punch', 'thunder-punch', 'stomp', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'mimic', 'double-team', 'defense-curl', 'self-destruct', 'amnesia', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'lock-on', 'sandstorm', 'endure', 'rollout', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'rock-smash', 'facade', 'focus-punch', 'superpower', 'brick-break', 'secret-power', 'rock-tomb', 'aerial-ace', 'iron-defense', 'block', 'shock-wave', 'gravity', 'hammer-arm', 'natural-gift', 'fling', 'magnet-rise', 'rock-polish', 'focus-blast', 'giga-impact', 'shadow-claw', 'flash-cannon', 'rock-climb', 'iron-head', 'stealth-rock', 'charge-beam', 'hone-claws', 'round', 'bulldoze', 'confide', 'power-up-punch'], 'name': 'registeel', 'stats': {'hp': 80, 'attack': 75, 'defense': 150, 'special-attack': 75, 'special-defense': 150, 'speed': 50}, 'types': ['steel'], 'weight': 2050, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'gray', 'shape': 'humanoid', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'レジスチル', 'roomaji': 'Registeel', 'ko': '레지스틸', 'zh-Hant': '雷吉斯奇魯', 'fr': 'Registeel', 'de': 'Registeel', 'es': 'Registeel', 'it': 'Registeel', 'en': 'Registeel', 'ja': 'レジスチル', 'zh-Hans': '雷吉斯奇鲁'}, 'genera': {'ja-Hrkt': 'くろがねポケモン', 'ko': '쇠철포켓몬', 'zh-Hant': '黑金寶可夢', 'fr': 'Pokémon Fer', 'de': 'Eisen', 'es': 'Pokémon Hierro', 'it': 'Pokémon Ferro', 'en': 'Iron Pokémon', 'ja': 'くろがねポケモン', 'zh-Hans': '黑金宝可梦'}}
	public class SpecieRegisteel : PokemonSpecie
	{
#nullable enable
		private static SpecieRegisteel? _instance = null;
#nullable restore
        public static SpecieRegisteel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRegisteel();
                }
                return _instance;
            }
        }

		public SpecieRegisteel() : base(
			"Registeel",
			80, // HPs
			75, 150, // Attack & Defense
			75, 150, // Special Attack & Defense
			50			
		) {}
	}


	//Registeel Pokemon Class
	public class Registeel : Pokemon
	{

		public Registeel(string nickname, int level) : base(
			379,
			SpecieRegisteel.Instance, // Pokemon Specie
			nickname, level,
			Steel.Instance			
		) {}

		public Registeel() : base(
			379,
			SpecieRegisteel.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
	}
}