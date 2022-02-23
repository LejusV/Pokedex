using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mudkip Specie to store common natural stats of every {'abilities': ['torrent', 'damp'], 'base_experience': 62, 'height': 4, 'id': 258, 'moves': ['stomp', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'bite', 'growl', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'low-kick', 'counter', 'strength', 'rock-throw', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'barrier', 'bide', 'sludge', 'waterfall', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'foresight', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'mirror-coat', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'hail', 'facade', 'superpower', 'yawn', 'endeavor', 'refresh', 'secret-power', 'dive', 'mud-sport', 'ice-ball', 'rock-tomb', 'water-pulse', 'natural-gift', 'aqua-tail', 'earth-power', 'avalanche', 'mud-bomb', 'captivate', 'wide-guard', 'sludge-wave', 'round', 'echoed-voice', 'scald', 'water-pledge', 'work-up', 'confide'], 'name': 'mudkip', 'stats': {'hp': 50, 'attack': 70, 'defense': 50, 'special-attack': 50, 'special-defense': 50, 'speed': 40}, 'types': ['water'], 'weight': 76, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'ミズゴロウ', 'roomaji': 'Mizugorou', 'ko': '물짱이', 'zh-Hant': '水躍魚', 'fr': 'Gobou', 'de': 'Hydropi', 'es': 'Mudkip', 'it': 'Mudkip', 'en': 'Mudkip', 'ja': 'ミズゴロウ', 'zh-Hans': '水躍鱼'}, 'genera': {'ja-Hrkt': 'ぬまうおポケモン', 'ko': '늪물고기포켓몬', 'zh-Hant': '沼魚寶可夢', 'fr': 'Pokémon Poissonboue', 'de': 'Lehmhüpfer', 'es': 'Pokémon Pez Lodo', 'it': 'Pokémon Fango Pesce', 'en': 'Mud Fish Pokémon', 'ja': 'ぬまうおポケモン', 'zh-Hans': '沼鱼宝可梦'}}
	public class SpecieMudkip : PokemonSpecie
	{
#nullable enable
		private static SpecieMudkip? _instance = null;
#nullable restore
        public static SpecieMudkip Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMudkip();
                }
                return _instance;
            }
        }

		public SpecieMudkip() : base(
			"Mudkip",
			50, // HPs
			70, 50, // Attack & Defense
			50, 50, // Special Attack & Defense
			40			
		) {}
	}


	//Mudkip Pokemon Class
	public class Mudkip : Pokemon
	{

		public Mudkip(string nickname, int level) : base(
			258,
			SpecieMudkip.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Mudkip() : base(
			258,
			SpecieMudkip.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}