using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gulpin Specie to store common natural stats of every {'abilities': ['liquid-ooze', 'sticky-hold', 'gluttony'], 'base_experience': 60, 'height': 4, 'id': 316, 'moves': ['pound', 'fire-punch', 'ice-punch', 'thunder-punch', 'headbutt', 'body-slam', 'double-edge', 'ice-beam', 'counter', 'strength', 'solar-beam', 'toxic', 'mimic', 'double-team', 'defense-curl', 'self-destruct', 'smog', 'sludge', 'amnesia', 'dream-eater', 'poison-gas', 'acid-armor', 'explosion', 'rest', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'destiny-bond', 'giga-drain', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'dynamic-punch', 'encore', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'stockpile', 'spit-up', 'swallow', 'facade', 'yawn', 'snatch', 'secret-power', 'bullet-seed', 'shock-wave', 'water-pulse', 'natural-gift', 'wring-out', 'gastro-acid', 'seed-bomb', 'gunk-shot', 'captivate', 'venoshock', 'sludge-wave', 'acid-spray', 'round', 'belch', 'confide', 'venom-drench', 'infestation', 'power-up-punch'], 'name': 'gulpin', 'stats': {'hp': 70, 'attack': 43, 'defense': 53, 'special-attack': 43, 'special-defense': 53, 'speed': 40}, 'types': ['poison'], 'weight': 103, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 225, 'color': 'green', 'shape': 'arms', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ゴクリン', 'roomaji': 'Gokulin', 'ko': '꼴깍몬', 'zh-Hant': '溶食獸', 'fr': 'Gloupti', 'de': 'Schluppuck', 'es': 'Gulpin', 'it': 'Gulpin', 'en': 'Gulpin', 'ja': 'ゴクリン', 'zh-Hans': '溶食兽'}, 'genera': {'ja-Hrkt': 'いぶくろポケモン', 'ko': '밥통포켓몬', 'zh-Hant': '胃袋寶可夢', 'fr': 'Pokémon Estomac', 'de': 'Magen', 'es': 'Pokémon Estómago', 'it': 'Pokémon Stomaco', 'en': 'Stomach Pokémon', 'ja': 'いぶくろポケモン', 'zh-Hans': '胃袋宝可梦'}}
	public class SpecieGulpin : PokemonSpecie
	{
#nullable enable
		private static SpecieGulpin? _instance = null;
#nullable restore
        public static SpecieGulpin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGulpin();
                }
                return _instance;
            }
        }

		public SpecieGulpin() : base(
			"Gulpin",
			70, // HPs
			43, 53, // Attack & Defense
			43, 53, // Special Attack & Defense
			40			
		) {}
	}


	//Gulpin Pokemon Class
	public class Gulpin : Pokemon
	{

		public Gulpin(string nickname, int level)
		: base(
				316,
				SpecieGulpin.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gulpin() : base(
			316,
			SpecieGulpin.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}