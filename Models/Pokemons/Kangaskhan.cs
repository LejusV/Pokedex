using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kangaskhan Specie to store common natural stats of every {'abilities': ['early-bird', 'scrappy', 'inner-focus'], 'base_experience': 172, 'height': 22, 'id': 115, 'moves': ['comet-punch', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'cut', 'stomp', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'leer', 'bite', 'roar', 'disable', 'flamethrower', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'focus-energy', 'bide', 'fire-blast', 'skull-bash', 'dizzy-punch', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'reversal', 'spite', 'protect', 'mud-slap', 'zap-cannon', 'foresight', 'icy-wind', 'outrage', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'whirlpool', 'fake-out', 'uproar', 'hail', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'endeavor', 'secret-power', 'crush-claw', 'rock-tomb', 'aerial-ace', 'covet', 'shock-wave', 'water-pulse', 'hammer-arm', 'natural-gift', 'fling', 'trump-card', 'sucker-punch', 'aqua-tail', 'drain-punch', 'focus-blast', 'giga-impact', 'avalanche', 'shadow-claw', 'rock-climb', 'captivate', 'double-hit', 'round', 'chip-away', 'circle-throw', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'confide', 'power-up-punch'], 'name': 'kangaskhan', 'stats': {'hp': 105, 'attack': 95, 'defense': 80, 'special-attack': 40, 'special-defense': 80, 'speed': 90}, 'types': ['normal'], 'weight': 800, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 45, 'color': 'brown', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'ガルーラ', 'roomaji': 'Garura', 'ko': '캥카', 'zh-Hant': '袋獸', 'fr': 'Kangourex', 'de': 'Kangama', 'es': 'Kangaskhan', 'it': 'Kangaskhan', 'en': 'Kangaskhan', 'ja': 'ガルーラ', 'zh-Hans': '袋兽'}, 'genera': {'ja-Hrkt': 'おやこポケモン', 'ko': '가족포켓몬', 'zh-Hant': '親子寶可夢', 'fr': 'Pokémon Maternel', 'de': 'Muttertier', 'es': 'Pokémon Padres', 'it': 'Pokémon Genitore', 'en': 'Parent Pokémon', 'ja': 'おやこポケモン', 'zh-Hans': '亲子宝可梦'}}
	public class SpecieKangaskhan : PokemonSpecie
	{
#nullable enable
		private static SpecieKangaskhan? _instance = null;
#nullable restore
        public static SpecieKangaskhan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKangaskhan();
                }
                return _instance;
            }
        }

		public SpecieKangaskhan() : base(
			"Kangaskhan",
			105, // HPs
			95, 80, // Attack & Defense
			40, 80, // Special Attack & Defense
			90			
		) {}
	}


	//Kangaskhan Pokemon Class
	public class Kangaskhan : Pokemon
	{

		public Kangaskhan(string nickname, int level) : base(
			115,
			SpecieKangaskhan.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Kangaskhan() : base(
			115,
			SpecieKangaskhan.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}