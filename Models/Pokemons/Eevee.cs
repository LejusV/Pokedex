using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Eevee Specie to store common natural stats of every {'abilities': ['run-away', 'adaptability', 'anticipation'], 'base_experience': 65, 'height': 3, 'id': 133, 'moves': ['sand-attack', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'bite', 'growl', 'dig', 'toxic', 'quick-attack', 'rage', 'mimic', 'double-team', 'reflect', 'focus-energy', 'bide', 'swift', 'skull-bash', 'rest', 'substitute', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'detect', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'baton-pass', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'facade', 'helping-hand', 'wish', 'yawn', 'refresh', 'secret-power', 'hyper-voice', 'fake-tears', 'tickle', 'covet', 'natural-gift', 'trump-card', 'last-resort', 'captivate', 'synchronoise', 'round', 'echoed-voice', 'stored-power', 'retaliate', 'work-up', 'confide', 'baby-doll-eyes'], 'name': 'eevee', 'stats': {'hp': 55, 'attack': 55, 'defense': 50, 'special-attack': 45, 'special-defense': 65, 'speed': 55}, 'types': ['normal'], 'weight': 65, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 1, 'capture_rate': 45, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'イーブイ', 'roomaji': 'Eievui', 'ko': '이브이', 'zh-Hant': '伊布', 'fr': 'Évoli', 'de': 'Evoli', 'es': 'Eevee', 'it': 'Eevee', 'en': 'Eevee', 'ja': 'イーブイ', 'zh-Hans': '伊布'}, 'genera': {'ja-Hrkt': 'しんかポケモン', 'ko': '진화포켓몬', 'zh-Hant': '進化寶可夢', 'fr': 'Pokémon Évolutif', 'de': 'Evolution', 'es': 'Pokémon Evolución', 'it': 'Pokémon Evoluzione', 'en': 'Evolution Pokémon', 'ja': 'しんかポケモン', 'zh-Hans': '进化宝可梦'}}
	public class SpecieEevee : PokemonSpecie
	{
#nullable enable
		private static SpecieEevee? _instance = null;
#nullable restore
        public static SpecieEevee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEevee();
                }
                return _instance;
            }
        }

		public SpecieEevee() : base(
			"Eevee",
			55, // HPs
			55, 50, // Attack & Defense
			45, 65, // Special Attack & Defense
			55			
		) {}
	}


	//Eevee Pokemon Class
	public class Eevee : Pokemon
	{

		public Eevee(string nickname, int level) : base(
			133,
			SpecieEevee.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Eevee() : base(
			133,
			SpecieEevee.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}