using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rhyperior Specie to store common natural stats of every {'abilities': ['lightning-rod', 'solid-rock', 'reckless'], 'base_experience': 241, 'height': 24, 'id': 464, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'cut', 'stomp', 'headbutt', 'horn-attack', 'fury-attack', 'horn-drill', 'take-down', 'tail-whip', 'roar', 'flamethrower', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'thunderbolt', 'thunder', 'earthquake', 'dig', 'toxic', 'double-team', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'mud-slap', 'icy-wind', 'outrage', 'sandstorm', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'megahorn', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'facade', 'focus-punch', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'rock-tomb', 'block', 'rock-blast', 'shock-wave', 'hammer-arm', 'natural-gift', 'payback', 'fling', 'rock-polish', 'poison-jab', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'avalanche', 'shadow-claw', 'flash-cannon', 'rock-climb', 'rock-wrecker', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'smack-down', 'round', 'chip-away', 'incinerate', 'bulldoze', 'dragon-tail', 'drill-run', 'confide', 'power-up-punch', 'smart-strike', 'brutal-swing'], 'name': 'rhyperior', 'stats': {'hp': 115, 'attack': 140, 'defense': 130, 'special-attack': 55, 'special-defense': 55, 'speed': 40}, 'types': ['ground', 'rock'], 'weight': 2828, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 30, 'color': 'gray', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'ドサイドン', 'roomaji': 'Dosydon', 'ko': '거대코뿌리', 'zh-Hant': '超甲狂犀', 'fr': 'Rhinastoc', 'de': 'Rihornior', 'es': 'Rhyperior', 'it': 'Rhyperior', 'en': 'Rhyperior', 'ja': 'ドサイドン', 'zh-Hans': '超甲狂犀'}, 'genera': {'ja-Hrkt': 'ドリルポケモン', 'ko': '드릴포켓몬', 'zh-Hant': '鑽錐寶可夢', 'fr': 'Pokémon Perceur', 'de': 'Bohrer', 'es': 'Pokémon Taladro', 'it': 'Pokémon Trapano', 'en': 'Drill Pokémon', 'ja': 'ドリルポケモン', 'zh-Hans': '钻锥宝可梦'}}
	public class SpecieRhyperior : PokemonSpecie
	{
#nullable enable
		private static SpecieRhyperior? _instance = null;
#nullable restore
        public static SpecieRhyperior Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRhyperior();
                }
                return _instance;
            }
        }

		public SpecieRhyperior() : base(
			"Rhyperior",
			115, // HPs
			140, 130, // Attack & Defense
			55, 55, // Special Attack & Defense
			40			
		) {}
	}


	//Rhyperior Pokemon Class
	public class Rhyperior : Pokemon
	{

		public Rhyperior(string nickname, int level) : base(
			464,
			SpecieRhyperior.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance, Rock.Instance			
		) {}

		public Rhyperior() : base(
			464,
			SpecieRhyperior.Instance, // Pokemon Specie
			Ground.Instance, Rock.Instance			
		) {}
	}
}