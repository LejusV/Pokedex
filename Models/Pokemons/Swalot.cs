using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Swalot Specie to store common natural stats of every {'abilities': ['liquid-ooze', 'sticky-hold', 'gluttony'], 'base_experience': 163, 'height': 17, 'id': 317, 'moves': ['pound', 'fire-punch', 'ice-punch', 'thunder-punch', 'headbutt', 'body-slam', 'double-edge', 'ice-beam', 'hyper-beam', 'counter', 'strength', 'solar-beam', 'earthquake', 'toxic', 'mimic', 'double-team', 'defense-curl', 'self-destruct', 'sludge', 'amnesia', 'dream-eater', 'poison-gas', 'explosion', 'rest', 'substitute', 'nightmare', 'snore', 'protect', 'sludge-bomb', 'mud-slap', 'giga-drain', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'dynamic-punch', 'encore', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'stockpile', 'spit-up', 'swallow', 'facade', 'yawn', 'snatch', 'secret-power', 'bullet-seed', 'block', 'shock-wave', 'water-pulse', 'natural-gift', 'wring-out', 'gastro-acid', 'seed-bomb', 'giga-impact', 'gunk-shot', 'captivate', 'venoshock', 'sludge-wave', 'acid-spray', 'round', 'bulldoze', 'belch', 'confide', 'venom-drench', 'infestation', 'power-up-punch'], 'name': 'swalot', 'stats': {'hp': 100, 'attack': 73, 'defense': 83, 'special-attack': 73, 'special-defense': 83, 'speed': 55}, 'types': ['poison'], 'weight': 800, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'purple', 'shape': 'arms', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'マルノーム', 'roomaji': 'Marunoom', 'ko': '꿀꺽몬', 'zh-Hant': '吞食獸', 'fr': 'Avaltout', 'de': 'Schlukwech', 'es': 'Swalot', 'it': 'Swalot', 'en': 'Swalot', 'ja': 'マルノーム', 'zh-Hans': '吞食兽'}, 'genera': {'ja-Hrkt': 'どくぶくろポケモン', 'ko': '독봉지포켓몬', 'zh-Hant': '毒袋寶可夢', 'fr': 'Pokémon Sac Poison', 'de': 'Giftbeutel', 'es': 'Pokémon Bolsa Veneno', 'it': 'Pokémon Velenosacco', 'en': 'Poison Bag Pokémon', 'ja': 'どくぶくろポケモン', 'zh-Hans': '毒袋宝可梦'}}
	public class SpecieSwalot : PokemonSpecie
	{
#nullable enable
		private static SpecieSwalot? _instance = null;
#nullable restore
        public static SpecieSwalot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwalot();
                }
                return _instance;
            }
        }

		public SpecieSwalot() : base(
			"Swalot",
			100, // HPs
			73, 83, // Attack & Defense
			73, 83, // Special Attack & Defense
			55			
		) {}
	}


	//Swalot Pokemon Class
	public class Swalot : Pokemon
	{

		public Swalot(string nickname, int level) : base(
			317,
			SpecieSwalot.Instance, // Pokemon Specie
			nickname, level,
			Poison.Instance			
		) {}

		public Swalot() : base(
			317,
			SpecieSwalot.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}